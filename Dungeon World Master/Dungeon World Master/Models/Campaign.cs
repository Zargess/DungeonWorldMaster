using Dungeon_World_Master.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Campaign : ICampaign {
        public ICollection<ICharacter> Characters { get; }

        public string Name { get; private set; }

        public Campaign() {
            
        }
    }
}
