using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTimer : MonoBehaviour {
    /// <summary>
    ///How Many Seconds this object has existed 
    /// </summary>
    float age = 0;
	// Update is called once per frame
	void Update () {
        age += Time.deltaTime;
        if(age > 3)
        {
            Destroy(gameObject);
        }
	}
}
