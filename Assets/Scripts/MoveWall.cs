using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public GameObject wall;

    // booleans to determine how to move the wall
    public bool moveRoom1 = false;
    public bool moveRoom2 = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collided");
        // wall is perpendicular to the x axis --> only change x component
        Vector3 orig_pos = wall.transform.position;

        if (moveRoom1)
        {
            Debug.Log("Moving wall for room 1");
            wall.transform.position = new Vector3(-2.5f, orig_pos.y, orig_pos.z);
        }
        else if (moveRoom2)
        {
            Debug.Log("Moving wall for room 2");
            wall.transform.position = new Vector3(2.5f, orig_pos.y, orig_pos.z);
        }

    }
}
