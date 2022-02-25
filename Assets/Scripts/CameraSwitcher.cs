using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera thirdPerson;
    public Camera topDown;

    void Start()
    {
        thirdPerson.enabled = true;
        topDown.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (thirdPerson.enabled)
            {
                thirdPerson.enabled = false;
                topDown.enabled = true;
                thirdPerson.gameObject.SetActive(false);
                topDown.gameObject.SetActive(true);
                Debug.Log("THIRD PERSON");
            }
            else
            {
                thirdPerson.enabled = true;
                topDown.enabled = false;
                thirdPerson.gameObject.SetActive(true);
                topDown.gameObject.SetActive(false);
                Debug.Log("TOP DOWN");
            }
            //Debug.Log(Camera.main);

        }
    }
}
