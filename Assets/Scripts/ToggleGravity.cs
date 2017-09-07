using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //space bar is jump
        if (Input.GetButton("Jump"))
        {
            //inside rigid body component, we need to reach into a different component in our object and change it
            //unity get component
            //GetComponent().useGravity = true;

            Rigidbody body = GetComponent<Rigidbody>();
            if (body != null) body.useGravity = true;
        }
        //  if(jump )
    }
}
