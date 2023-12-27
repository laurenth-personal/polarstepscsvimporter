using UnityEngine;
using UnityEditor.AssetImporters;
using System.IO;
using System.Collections.Generic;

[ScriptedImporter(1, "coord")]
public class CoordinatesImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        var stringContent = File.ReadAllText(ctx.assetPath);
        stringContent = stringContent.Remove(0, 15);
        stringContent = stringContent.Replace("\r\n", "\n");
        var list = ScriptableObject.CreateInstance<CoordinatesList>();
        list.name = "Voyage";

        var lines = stringContent.Split('\n');
        list.coordinateslist = new Vector3[lines.Length];
        for (int i = 0; i < list.coordinateslist.Length; i++)
        {
            var coord = lines[i].Split(',');
            if(coord.Length==3)
            {
                if (!float.TryParse(coord[0], out list.coordinateslist[i].x))
                    Debug.Log("issue with string " + coord[0]);
                if (!float.TryParse(coord[1], out list.coordinateslist[i].y))
                    Debug.Log("issue with string " + coord[1]);
                if (!float.TryParse(coord[2], out list.coordinateslist[i].z))
                    Debug.Log("issue with string " + coord[2]);
            }

        }
        ctx.AddObjectToAsset("Voyage", list);
    }
}