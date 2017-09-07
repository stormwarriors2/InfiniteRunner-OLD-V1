using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoved : MonoBehaviour {
    Vector3 velocity = new Vector3();
    public int speed = 10;
    public int JumpHeight = 8;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float axisH = Input.GetAxis("Horizontal");
        float axisY = Input.GetAxis("Jump");
        //
        velocity += speed * new Vector3(0, axisY, 0) * Time.deltaTime;
            
        velocity += speed * new Vector3(axisH, 0, 0) * Time.deltaTime; // acceleration
        transform.position += velocity * Time.deltaTime; //velocity
        if(axisH == 0) velocity *= .5f; //slow down!
        if (axisY == 0)
        {
            velocity *= .3f;
           
        }

       // if (axisY == 0) velocity *= .5f;
    }
}
//demonstration of velocity and player objects
//merely meant to show you how to do euler physics
//state machine
//to DO : player can change lanes Done
//TO DO : make Player Jump
// TO DO: Spawn OBJECT 