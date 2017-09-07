using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Controller : MonoBehaviour {

    public GameObject prefabSphere;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            //spawn sphere
            //calls a function
            //           Instantiate(Actors.WeirdSphere)
            float x = Random.Range(-10, 10);
            float y = Random.Range(-10, 10);
            float z = Random.Range(-10, 10);

            Instantiate(prefabSphere, new Vector3(x,y,z), Quaternion.identity);
        }	
	}
}
