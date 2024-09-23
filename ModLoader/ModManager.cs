using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class ModManager
{
    public List<string> modsList = new();

    public static string modsFolder = "user://mods/";

    public void Start()
    {
        LoadMods();
    }

    public void LoadMods()
    {
        using DirAccess dir = DirAccess.Open(modsFolder);
        if(dir != null)
        {
            dir.ListDirBegin();
            string mod = dir.GetNext();
            while(mod != "")
            {
                if(dir.CurrentIsDir())
                {
                    openMod(modsFolder + mod);
                }
                mod = dir.GetNext();
            }
        }
        
    }

    public void openMod(string path)
    {
        GD.Print(path);
        using DirAccess dir = DirAccess.Open(path);
        string modID = "";
        if(dir.FileExists("modid.txt"))
        {
            using FileAccess tmp = FileAccess.Open(path + "/modid.txt", FileAccess.ModeFlags.Read);
            modID = tmp.GetAsText();
            modsList.Add(modID);
        }
        GD.Print(modID);
    }
}
