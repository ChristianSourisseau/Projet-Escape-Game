using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Objet : ScriptableObject
{
    //Each object has a name and a description
    //this information is stored in a txt file, unique as it's stored with it's instance ID.
    
    public TextAsset createText()
    {
        int id = this.GetInstanceID();
        TextAsset txt = new TextAsset();
        string path = "/Resources/" + id + ".txt";

        //writing file
        File.WriteAllText(Application.dataPath + path, this.name + '\n' + this.description);

        //getting TextAsset
        txt = Resources.Load(id.ToString()) as TextAsset;
        Debug.Assert(txt != null, "creation of txt file for"+this.name+" failed");
        return txt;
    }

    public string description = "an object";
    new public string name = "Object"; //overriding the old definition for name
    public Sprite icon = null;
}
