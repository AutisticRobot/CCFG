using Godot;
using System;

public partial class globalGauntlet : Node
{
    //Critters
    public crit CritterSlot1;
    public crit CritterSlot2;
    public crit CritterSlot3;
    public crit CritterSlot4;
    public crit CritterSlot5;

    public int critterToScan;

    public crit GetCrit(int Index)
    {
        return Index switch
        {
            0 => CritterSlot1,
            1 => CritterSlot2,
            2 => CritterSlot3,
            3 => CritterSlot4,
            4 => CritterSlot5,
            _ => null,
        };
    }
    public crit SetCrit(int Index, crit newCrit)
    {
        return Index switch
        {
            0 => CritterSlot1 = newCrit,
            1 => CritterSlot2 = newCrit,
            2 => CritterSlot3 = newCrit,
            3 => CritterSlot4 = newCrit,
            4 => CritterSlot5 = newCrit,
            _ => null,
        };
    }

    public void ScanCritter(int critIndex)
    {
        critterToScan = critIndex;

        GetTree().ChangeSceneToFile("res://Scences/scan.tscn");
    }
    
    public void changeToScene(string scenePath)
    {
        GetTree().ChangeSceneToFile(scenePath);
    }
}
