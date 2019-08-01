using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Vector3 move;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.Left))
        {
            move = new Vector3(-1f, 0f, 0f);
        }
        if (OVRInput.GetDown(OVRInput.Button.Right))
        {
            move = new Vector3( 1f, 0f, 0f);
        }

        transform.position = move;
    }
}

