using Godot;
using System;

public partial class GauntButt : Button
{
			 public crit critter;
			 public int critID;
             public globalGauntlet glob;



	public void start()
	{
		if(critter != null)
		{
			Icon = critter.Pic;
		}else{
			Icon = null;
		}
	}

	public void OnPress()
	{
		glob.ScanCritter(critID);

	}
}
