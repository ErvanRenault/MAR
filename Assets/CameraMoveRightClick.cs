﻿using UnityEngine;
using System.Collections;

public class CameraMoveRightClick : MonoBehaviour {

    float speed = 10.0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetAxis("Mouse ScrollWheel") > 0) { GetComponent<Camera>().fieldOfView = GetComponent<Camera>().fieldOfView - 5; }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) { GetComponent<Camera>().fieldOfView = GetComponent<Camera>().fieldOfView + 5; }

       
        if (Input.GetKey(KeyCode.Z)) { transform.Rotate(Vector3.left); }
        if (Input.GetKey(KeyCode.S)) { transform.Rotate(Vector3.right); }
        if (Input.GetKey(KeyCode.Q)) { transform.Rotate(Vector3.down); }
        if (Input.GetKey(KeyCode.D)) { transform.Rotate(Vector3.up); }


        if (Input.GetMouseButton(1))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                           0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);

            }
  
            else if (Input.GetAxis("Mouse X") < 0)
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                           0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }
        }

    }

    private void LateUpdate()
    {
        
    }
}


