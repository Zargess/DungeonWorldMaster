namespace Dungeon_World_Master.Interfaces {
    public interface ICharacter {
        int Level { get; set; }
        string Name { get; }

        IStat[] Stats { get; }

    }
}