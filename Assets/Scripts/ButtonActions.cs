//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    private bool texEnabled = false;
    //private GameObject[] allGameObjects;

    public void SwitchScenes()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
        if (scene.name == "Scene 1")
        {
            SceneManager.LoadScene("Scene 2");
        }
        else
        {
            SceneManager.LoadScene("Scene 1");
        }
    }

    public void ToggleTextures()
    {
        Debug.Log(GlobalVars.texturesEnabled);
        GlobalVars.texturesEnabled = !GlobalVars.texturesEnabled;
        //allGameObjects = Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject;
        foreach (GameObject i in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[]) {
            if (i.GetComponent<ChangeMaterial>() != null) {
                //Debug.Log("Material Changeable");
                i.GetComponent<ChangeMaterial>().changeMaterial();
            }
            //i.GetComponent<ChangeMaterial>().changeMaterial();
        }
    }

    public void ToggleDayNight() {
        Debug.Log(GlobalVars.isDay);
        //Debug.Log(RenderSettings.skybox.GetColor("Gradient_Bottom"));
        //Debug.Log(RenderSettings.skybox.GetColor("Gradient_Top"));
        //Color currentTop = RenderSettings.skybox.GetColor("Gradient_Top");
        //Color currentBottom = RenderSettings.skybox.GetColor("Gradient_Bottom");
        //float currentStop = RenderSettings.skybox.GetFloat("Gradient_Stop_Position");

        if (!GlobalVars.isDay)
        {
            //RenderSettings.skybox.SetColor("Gradient_Top", Color.Lerp(currentTop, nightTop, 5f));
            //RenderSettings.skybox.SetColor("Gradient_Bottom", Color.Lerp(currentBottom, nightBottom, 5f));
            //RenderSettings.skybox.SetFloat("Gradient_Stop_Position", Mathf.Lerp(currentStop, nightStop, 5f));
            //RenderSettings.skybox.SetColor("Gradient_Bottom", new Color((float)0.112, (float)0.113, (float)0.302, (float)0.00));
            //RenderSettings.skybox.SetFloat("Gradient_Stop_Position", 2f);
            GlobalVars.isDay = true;
        }
        else {
            //RenderSettings.skybox.SetColor("Gradient_Top", Color.Lerp(currentTop, dayTop, 5f));
            //RenderSettings.skybox.SetColor("Gradient_Bottom", Color.Lerp(currentBottom, dayBottom, 5f));
            //RenderSettings.skybox.SetFloat("Gradient_Stop_Position", Mathf.Lerp(currentStop, dayStop, 5f));
            //RenderSettings.skybox.SetColor("Gradient_Top", new Color((float)0.872, (float)0.950, (float)1.00, (float)0.00));
            //RenderSettings.skybox.SetColor("Gradient_Bottom", new Color((float)0.000, (float)0.569, (float)0.792, (float)0.00));
            //RenderSettings.skybox.SetFloat("Gradient_Stop_Position", 1f);
            GlobalVars.isDay = false;
        }
        //RenderSettings.skybox.SetColor("Gradient_Top")
        //Material mat = Resources.Load<Material>("./Night Skybox Material.mat");
        //Debug.Log(mat);
        //RenderSettings.skybox = null;
    }

    public void AnimatePlayer() {
        Animator ani = GameObject.Find("Player").GetComponent<Animator>();
        ani.Play("Base Layer.Player Spin", 0, 0.0f);
    }
}
