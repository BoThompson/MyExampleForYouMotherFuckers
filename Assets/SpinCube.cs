using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : Cube {

   
    // Update is called once per frame
    void Update () {
		
	}

    override public void Move()
    {
        transform.Rotate(new Vector3(0, 0, 45));
    }
}
