using Godot;
using System;

public partial class critView : Node
{
    [Export] public string targetScenePath;
    [Export] public Label text;
    [Export] public Sprite2D sprite;

             public crit Critter;

             public globalGauntlet glob;

    public override void _Ready()
    {
        glob = GetNode<globalGauntlet>("/root/GlobalGauntlet");

        scan(glob.GetCrit(glob.critterToScan));
    }

    public override void _Process(double delta)
    {
    }

    public void scan(crit critter)
    {
        if(critter != null)
        {
            Critter = critter;

            if(critter.Nickname != "")
            {
                text.Text = critter.Nickname;
            }else{
                text.Text = critter.Name;
            }

            sprite.Texture = critter.Pic;
        }else{
            text.Text = "Empty";
            sprite.Texture = null;
        }

    }

    public void newCrit()
    {
        Critter = new man();
        scan(Critter);
    }

    public void OnPress()
    {
        glob.SetCrit(glob.critterToScan, Critter);
        glob.changeToScene(targetScenePath);
    }
}
