using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f;
    private float lrInput;
    private float fbInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lrInput = Input.GetAxis("Horizontal");
        fbInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fbInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * lrInput);
    }
}
