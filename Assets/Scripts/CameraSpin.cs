using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 1, transform.eulerAngles.z);


        // Vector3 rot = transform.eulerAngles;
        // rot.y += 1;
        // transform.eulerAngles = rot;

        transform.Rotate(0, 60 * Time.deltaTime, 0);
	}
}
