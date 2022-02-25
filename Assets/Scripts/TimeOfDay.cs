using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
    private Color dayTop = new Color((float)0.872, (float)0.950, (float)1.00, (float)0.00);
    private Color dayBottom = new Color((float)0.000, (float)0.569, (float)0.792, (float)0.00);
    private float dayStop = 1f;

    private Color nightTop = new Color((float)0.216, (float)0.327, (float)0.528, (float)0.00);
    private Color nightBottom = new Color((float)0.112, (float)0.113, (float)0.302, (float)0.00);
    private float nightStop = 2f;

    void Update() {
        Color currentTop = RenderSettings.skybox.GetColor("Gradient_Top");
        Color currentBottom = RenderSettings.skybox.GetColor("Gradient_Bottom");
        float currentStop = RenderSettings.skybox.GetFloat("Gradient_Stop_Position");

        if (!GlobalVars.isDay)
        {

            RenderSettings.skybox.SetColor("Gradient_Top", nightTop);
            RenderSettings.skybox.SetColor("Gradient_Bottom", nightBottom);
            RenderSettings.skybox.SetFloat("Gradient_Stop_Position", nightStop);
            GameObject.Find("Directional Light").GetComponent<Light>().intensity = 0.5f;
            //RenderSettings.skybox.SetColor("Gradient_Bottom", new Color((float)0.112, (float)0.113, (float)0.302, (float)0.00));
            //RenderSettings.skybox.SetFloat("Gradient_Stop_Position", 2f);
            //GlobalVars.isDay = true;
        }
        else
        {
            RenderSettings.skybox.SetColor("Gradient_Top", dayTop);
            RenderSettings.skybox.SetColor("Gradient_Bottom", dayBottom);
            RenderSettings.skybox.SetFloat("Gradient_Stop_Position", dayStop);
            GameObject.Find("Directional Light").GetComponent<Light>().intensity = 1.5f;
            //RenderSettings.skybox.SetColor("Gradient_Top", new Color((float)0.872, (float)0.950, (float)1.00, (float)0.00));
            //RenderSettings.skybox.SetColor("Gradient_Bottom", new Color((float)0.000, (float)0.569, (float)0.792, (float)0.00));
            //RenderSettings.skybox.SetFloat("Gradient_Stop_Position", 1f);
            //GlobalVars.isDay = false;
        }
    }
}
