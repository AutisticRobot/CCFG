using Godot;
using Godot.Collections;
using System;

public partial class bestiary : Node
{
    public Dictionary allCritters;
    public Dictionary allItems;
    public Dictionary allMoves;

    public ModManager mods = new();

    public override void _Ready()
    {
        mods.Start();
    }

}
