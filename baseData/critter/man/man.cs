using Godot;
using System;

public partial class man : crit
{
    public man()
    {
        Name = "man";
        Pic = (Texture2D)ResourceLoader.Load("res://baseData/critter/man/ccfgMan.png");
        
    }
}
