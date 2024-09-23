
using Godot;

public partial class gauntletMenu : Node
{


             public globalGauntlet glob;

    [Export] public GauntButt cirt1;
    [Export] public GauntButt cirt2;
    [Export] public GauntButt cirt3;
    [Export] public GauntButt cirt4;
    [Export] public GauntButt cirt5;

    public override void _Ready()
    {
        preLoad();
    }

    public void preLoad()
    {

        glob = GetNode<globalGauntlet>("/root/GlobalGauntlet");

        buttLoad(cirt1, 0);
        buttLoad(cirt2, 1);
        buttLoad(cirt3, 2);
        buttLoad(cirt4, 3);
        buttLoad(cirt5, 4);

    }

    private void buttLoad(GauntButt butt, int critID)
    {
        butt.glob = glob;
        butt.critID = critID;
        butt.critter = glob.GetCrit(critID);
        butt.start();
    }
}