using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //when user presses down
        //squish this object
        //else
        //unsquish object

        float inputV = Input.GetAxisRaw("Vertical");
        //returns float
        if (inputV == -1)
        {
            transform.localScale = new Vector3(1, .5f, 1);
        } 
        else
        {
            transform.localScale = new Vector3(1, 1, 1); //Vector3.one also works
        }

       
	}
}
