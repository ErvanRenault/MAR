using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

     
        if (Input.GetAxis ("Mouse ScrollWheel") > 0){GetComponent<Camera>().fieldOfView = GetComponent<Camera>().fieldOfView - 5; }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) { GetComponent<Camera>().fieldOfView = GetComponent<Camera>().fieldOfView + 5; }

        if (Input.GetKey(KeyCode.UpArrow)) { transform.Translate(Vector3.up); }
        if (Input.GetKey(KeyCode.DownArrow)) { transform.Translate(Vector3.down); }
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(Vector3.left); }
        if (Input.GetKey(KeyCode.RightArrow)) { transform.Translate(Vector3.right); }

        if (Input.GetKey(KeyCode.Q)) { transform.Rotate(Vector3.down); }
        if (Input.GetKey(KeyCode.D)) { transform.Rotate(Vector3.up); }
        if (Input.GetKey(KeyCode.Z)) { transform.Rotate(Vector3.left); }
        if (Input.GetKey(KeyCode.S)) { transform.Rotate(Vector3.right); }

        


    }
}
