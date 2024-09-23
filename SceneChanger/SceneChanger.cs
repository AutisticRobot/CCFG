using Godot;
using System;

public partial class SceneChanger : Button
{
    [Export] public string targetScenePath;
    public void OnPress()
    {
        GetNode<globalGauntlet>("/root/GlobalGauntlet").changeToScene(targetScenePath);
    }
}
