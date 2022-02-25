using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EmitParticle : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VisualEffect>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == player.name)
        {
            Debug.Log("Start Particles");
            GetComponent<VisualEffect>().Play();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == player.name)
        {
            Debug.Log("Stop Particles");
            GetComponent<VisualEffect>().Stop();
        }
    }
}
