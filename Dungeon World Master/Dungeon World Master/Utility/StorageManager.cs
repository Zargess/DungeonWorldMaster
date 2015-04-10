using Dungeon_World_Master.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.Storage;

namespace Dungeon_World_Master.Utility
{
    public class StorageManager
    {
        // TODO : Consider using JSON.NET instead for an easy way to serialize all data
        public static readonly string STORAGEFILE = "Data.xml";
        private static readonly StorageFolder _roamingfolder = ApplicationData.Current.RoamingFolder;
        private static readonly StorageFolder _localfolder = ApplicationData.Current.LocalFolder;

        private static async Task<bool> FileExists(StorageFolder folder)
        {
            try
            {
                await folder.GetFileAsync(STORAGEFILE);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #region Load
        public static async Task LoadAsync()
        {
            var file = await _roamingfolder.GetFileAsync(STORAGEFILE);
            var content = await FileIO.ReadTextAsync(file);

            var document = new XmlDocument();
            document.LoadXml(content);

            LoadProgram(document);
        }

        private static void LoadProgram(XmlDocument document)
        {
            LoadCampaigns(document.ChildNodes[0]);
            // TODO : Load enemies
        }

        private static void LoadCampaigns(IXmlNode xmlNode)
        {
            var campaigns = xmlNode.ChildNodes.ToList()[0];

            foreach (var campaign in campaigns.ChildNodes)
            {
                var values = campaign.Attributes.Select(x => x.NodeValue.ToString()).ToList();
                var campaignname = values[0];
                var c = new Campaign(campaignname);
                foreach (var character in campaign.ChildNodes[0].ChildNodes)
                {
                    var attributes = character.Attributes.Select(x => x.NodeValue.ToString()).ToList();
                    var name = attributes[0];
                    var alignment = attributes[1];
                    var race = attributes[2];
                    var Class = attributes[3];
                    var playername = attributes[4];
                    var level = Int32.Parse(attributes[5]);
                    var looks = attributes[6];
                    var stats = CreateStatsFromXml(character.ChildNodes[0]);
                    var notes = GetNotes(character.ChildNodes[1].ChildNodes);
                    c.Characters.Add(new Character(alignment, Class, level, name, notes, race, playername, looks, stats));
                }
                // TODO : Load cities and fronts
                App.ViewModel.Campaigns.Add(c);
            }
        }

        private static IEnumerable<Note> GetNotes(XmlNodeList childNodes)
        {
            var res = new List<Note>();
            foreach (var child in childNodes)
            {
                var attributes = child.Attributes.Select(x => x.NodeValue.ToString()).ToList();
                res.Add(new Note(attributes[0], child.InnerText));
            }
            return res;
        }

        private static Stat[] CreateStatsFromXml(IXmlNode xmlNode)
        {
            var resultat = new Stat[6];
            var attributes = xmlNode.Attributes.Select(x => Int32.Parse(x.NodeValue.ToString())).ToList();

            resultat[0] = new Stat("Strength", attributes[0]);
            resultat[1] = new Stat("Dexterity", attributes[1]);
            resultat[2] = new Stat("Constitution", attributes[2]);
            resultat[3] = new Stat("Intelligense", attributes[3]);
            resultat[4] = new Stat("Wisdom", attributes[4]);
            resultat[5] = new Stat("Charisma", attributes[5]);

            return resultat;
        }
        #endregion

        #region Save
        public static async Task SaveAsync()
        {
            try
            {
                var fileExists = await FileExists(_roamingfolder);
                if (fileExists) await BackUpExistingFile();
                var file = await _roamingfolder.CreateFileAsync(STORAGEFILE, CreationCollisionOption.ReplaceExisting);
                var xml = CreateXmlDocument();
                await xml.SaveToFileAsync(file);
                var properties = await file.GetBasicPropertiesAsync();
                if (properties.Size != 0) return;
                var localfile = await _localfolder.GetFileAsync(STORAGEFILE);
                var text = await FileIO.ReadTextAsync(localfile);
                await FileIO.WriteTextAsync(file, text);
            }
            catch (Exception ex)
            {
                var file = await _roamingfolder.CreateFileAsync(STORAGEFILE, CreationCollisionOption.ReplaceExisting);
                var localfile = await _localfolder.GetFileAsync(STORAGEFILE);
                var text = await FileIO.ReadTextAsync(localfile);
                await FileIO.WriteTextAsync(file, text);
            }
        }

        private static async Task BackUpExistingFile()
        {
            var file = await _roamingfolder.GetFileAsync(STORAGEFILE);
            var properties = await file.GetBasicPropertiesAsync();
            if (properties.Size == 0) return;
            var text = await FileIO.ReadTextAsync(file);
            var localfile = await _roamingfolder.CreateFileAsync(STORAGEFILE, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localfile, text);
        }

        private static XmlDocument CreateXmlDocument()
        {
            var result = new XmlDocument();
            var root = result.CreateElement("root");
            var campaigns = result.CreateElement("campaigns");

            var vm = App.ViewModel;

            foreach (var campaign in vm.Campaigns)
            {
                campaigns.AppendChild(CampaignToXmlElement(result, campaign));
            }
            root.AppendChild(campaigns);

            // TODO : Convert enemies to xml

            result.AppendChild(root);
            return result;
        }

        private static XmlElement CampaignToXmlElement(XmlDocument doc, Campaign campaign)
        {
            var result = doc.CreateElement("campaign");
            result.SetAttributeNode(CreateAttribute(doc, "name", campaign.Name));

            var characters = doc.CreateElement("characters");
            foreach (var character in campaign.Characters)
            {
                characters.AppendChild(CharacterToXmlElement(doc, character));
            }
            result.AppendChild(characters);

            // TODO : Convert notes, cities and fronts to xml

            return result;
        }

        public static XmlElement CharacterToXmlElement(XmlDocument doc, Character character)
        {
            var element = doc.CreateElement("character");

            var name = doc.CreateAttribute("name");
            name.Value = character.Name;
            element.SetAttributeNode(name);

            element.SetAttributeNode(CreateAttribute(doc, "name", character.Name));
            element.SetAttributeNode(CreateAttribute(doc, "alignment", character.Alignment));
            element.SetAttributeNode(CreateAttribute(doc, "race", character.Race));
            element.SetAttributeNode(CreateAttribute(doc, "class", character.Class));
            element.SetAttributeNode(CreateAttribute(doc, "playername", character.PlayerName));
            element.SetAttributeNode(CreateAttribute(doc, "level", character.Level));
            element.SetAttributeNode(CreateAttribute(doc, "looks", character.Looks));
            element.AppendChild(StatsToXmlElement(doc, character.Stats));

            var notes = doc.CreateElement("notes");

            foreach (var note in character.Notes)
            {
                var noteelement = doc.CreateElement("note");
                noteelement.SetAttributeNode(CreateAttribute(doc, "title", note.Title));
                noteelement.InnerText = note.Body;
                notes.AppendChild(noteelement);
            }

            element.AppendChild(notes);

            return element;
        }

        private static XmlElement StatsToXmlElement(XmlDocument doc, Stat[] stats)
        {
            var element = doc.CreateElement("stats");

            foreach (var stat in stats)
            {
                var attr = doc.CreateAttribute(stat.Name);
                attr.Value = stat.Score.ToString();
                element.SetAttributeNode(attr);
            }

            return element;
        }

        private static XmlAttribute CreateAttribute(XmlDocument doc, string name, object value)
        {
            var attr = doc.CreateAttribute(name);
            attr.Value = value.ToString();
            return attr;
        }
        #endregion
    }
}
