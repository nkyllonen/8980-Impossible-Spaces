using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickMove : MonoBehaviour
{
    //private SteamVR_Controller.Device Controller;
    //private SteamVR_TrackedController Controller;

    public GameObject camera;
    public GameObject cameraRig;

    public float speed = 1.0f;
    public float rotationSpeed = 25.0f;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // update camera's position
        Vector3 forward = camera.transform.forward;
        Debug.Log(Input.GetAxis("Vertical"));
        cameraRig.transform.position += forward * speed * Time.deltaTime * Input.GetAxis("Vertical");
        //float translation = Time.deltaTime * Input.GetAxis("Vertical") * speed;
        //camera.transform.Translate(0, 0, translation);

        // update camera's rotation
        float rotation = Time.deltaTime * Input.GetAxis("Horizontal") * rotationSpeed;
        cameraRig.transform.Rotate(0, rotation, 0);
    }
}
