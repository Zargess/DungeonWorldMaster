using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Interfaces {
    public interface IFront {
        string Name { get; set; }
        string Description { get; set; }
        ObservableCollection<IDanger> Dangers { get; }
        ObservableCollection<IGrimPortent> GrimPortents { get; }
    }
}
