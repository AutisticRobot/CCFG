using Godot;
using System;

public partial class critView : Node
{
    [Export] public Label text;
    [Export] public Sprite2D sprite;

    public override void _Ready()
    {
        scan(new man());
    }

    public override void _Process(double delta)
    {
    }

    public void scan(crit critter)
    {
        critter.Nickname = "Dave";

        if(critter.Nickname != "")
        {
            text.Text = critter.Nickname;
        }else{
            text.Text = critter.Name;
        }

        sprite.Texture = critter.Pic;

    }
}
