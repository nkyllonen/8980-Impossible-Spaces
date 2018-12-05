using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCamera : MonoBehaviour {
    public GameObject camera;

	// Use this for initialization
	void Start () {
        this.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
