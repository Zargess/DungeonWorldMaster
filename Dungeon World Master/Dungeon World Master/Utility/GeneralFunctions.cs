using Dungeon_World_Master.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Data.Xml.Dom;
using Windows.Storage;

namespace Dungeon_World_Master.Utility {
    public class GeneralFunctions {
        public static readonly string STORAGEFILE = "Campaigns.xml";
        private static StorageFile _file;

        public static Stat[] GenerateStats() {
            return new Stat[] {
                new Stat("Strength", 8),
                new Stat("Dexterity", 9),
                new Stat("Constitution", 12),
                new Stat("Intelligense", 13),
                new Stat("Wisdom", 15),
                new Stat("Charisma", 16)
            };
        }

        public static XmlElement CharacterToXElement(Character character) {
            var doc = new XmlDocument();
            var element = doc.CreateElement("character");

            var name = doc.CreateAttribute("name");
            name.Value = character.Name;
            element.SetAttributeNode(name);

            var alignment = doc.CreateAttribute("alignment");
            alignment.Value = character.Alignment;
            element.SetAttributeNode(alignment);

            var race = doc.CreateAttribute("race");
            race.Value = character.Race;
            element.SetAttributeNode(race);

            var Class = doc.CreateAttribute("class");
            Class.Value = character.Class;
            element.SetAttributeNode(Class);

            var playername = doc.CreateAttribute("playername");
            playername.Value = character.PlayerName;
            element.SetAttributeNode(playername);

            var level = doc.CreateAttribute("level");
            level.Value = character.Level.ToString();
            element.SetAttributeNode(level);

            element.AppendChild(StatsToXmlElement(character.Stats));

            var notes = doc.CreateElement("notes");
            notes.InnerText = character.Notes;
            element.AppendChild(notes);

            return element;
        }

        private static XmlElement StatsToXmlElement(Stat[] stats) {
            var doc = new XmlDocument();
            var element = doc.CreateElement("stats");

            var str = doc.CreateAttribute("str");
            str.Value = stats[0].Score.ToString();
            element.SetAttributeNode(str);

            var dex = doc.CreateAttribute("dex");
            dex.Value = stats[1].Score.ToString();
            element.SetAttributeNode(dex);

            var con = doc.CreateAttribute("con");
            con.Value = stats[2].Score.ToString();
            element.SetAttributeNode(con);

            var intelligense = doc.CreateAttribute("int");
            con.Value = stats[3].Score.ToString();
            element.SetAttributeNode(intelligense);

            var wis = doc.CreateAttribute("wis");
            wis.Value = stats[4].Score.ToString();
            element.SetAttributeNode(wis);

            var cha = doc.CreateAttribute("cha");
            cha.Value = stats[5].Score.ToString();
            element.SetAttributeNode(cha);

            return element;
        }

    }
}
