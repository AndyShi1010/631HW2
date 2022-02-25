using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
    public float speed = 0.12f;
    private Vector3 offset = new Vector3(0f, 2f, -5f);

    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    void LateUpdate()
    {
        Vector3 finalPos = target.position + offset;
        Vector3 lerpPos = Vector3.Lerp(transform.position, finalPos, speed);
        transform.position = lerpPos;
    }
}
