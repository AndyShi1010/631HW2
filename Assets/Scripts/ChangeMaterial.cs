using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material blankMaterial;
    public Material texturedMaterial;
    
    public void changeMaterial() {
        if (GlobalVars.texturesEnabled) {
            //Debug.Log("Textures Enabled");
            GetComponent<Renderer>().material = texturedMaterial;
        } else
        {
            //Debug.Log("Textures Disabled");
            GetComponent<Renderer>().material = blankMaterial;
        }
    }
}
