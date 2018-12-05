using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickMove : MonoBehaviour
{
    //private SteamVR_Controller.Device Controller;
    //private SteamVR_TrackedController Controller;

    public GameObject camera;

    public float speed = 1.0f;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // if joystick is moved more than .15, print the joystick coordinates
        /*if (Mathf.Abs(Controller.controllerState.rAxis2.x) > 0.15 || Mathf.Abs(Controller.controllerState.rAxis2.y) > 0.15)
        {
            Debug.Log("Joystick coordinates: " + Controller.controllerState.rAxis2.x + " " + Controller.controllerState.rAxis2.y);
        }
        */
        //Debug.Log("Parent: " + this.transform.parent.name);
        //Debug.Log("Update?");

        camera.transform.position += new Vector3(0.0f, 0.0f, speed) * Time.deltaTime * Input.GetAxis("Vertical");
        camera.transform.position += new Vector3(speed, 0.0f, 0.0f) * Time.deltaTime * Input.GetAxis("Horizontal");
    }
}
