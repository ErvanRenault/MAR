using UnityEngine;
using System.Collections;

public class TurnBackward : MonoBehaviour
{


    bool touch;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.UpArrow)) { touch = true; }
        if (Input.GetKey(KeyCode.DownArrow)) { touch = false; }
        if (touch == true)
        {
            transform.Rotate(Vector3.left);
        }
        else { transform.Rotate(Vector3.right); }

    }
}
