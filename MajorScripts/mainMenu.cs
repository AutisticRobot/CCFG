using Godot;
using System;

public partial class mainMenu : Node2D
{
	[Export] public ItemList modsList;

			 public globalGauntlet glob;
			 public bestiary bestiary;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        glob = GetNode<globalGauntlet>("/root/GlobalGauntlet");
        bestiary = GetNode<bestiary>("/root/Bestiary");

		foreach(string item in bestiary.mods.modsList)
		{
			modsList.AddItem(item);
			GD.Print("add mod to list: " + item);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
