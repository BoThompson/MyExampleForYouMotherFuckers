using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(RunCube))]
public class GrowCube : Cube {

   
    // Update is called once per frame
    void Update () {
		
	}

    override public void Move()
    {
        transform.localScale *= 2;
    }
}
