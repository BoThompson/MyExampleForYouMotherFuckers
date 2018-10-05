using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCube : Cube {


    // Update is called once per frame
    void Update () {
		
	}

    override public void Move()
    {
        transform.position += transform.forward * 2;
    }
}
