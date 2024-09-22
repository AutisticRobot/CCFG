using Godot;
using System;

public partial class crit
{
    //visual
    public Texture2D Pic;
    public string Name;
    public string Nickname = "";

    //L0 stats
    public int expReqMulti;
    public int L0MaxHealth;
    public int L0atk;
    public int L0def;

    //Level
    public int Level;
    public int exp;

    //combat stats
    public item heldItem;

    public int health;
    public int MaxHealth;

    public int atk;
    public int def;

    public type[] Types;
    public move[] Moves;
    public move[] MoveWhiteList;
    public move[] MoveBlackList;
}