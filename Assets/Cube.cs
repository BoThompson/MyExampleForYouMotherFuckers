using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        CubeManager.Instance.RegisterCube(this);
	}
	
    void OnDestroy()
    {
        CubeManager.Instance.DeregisterCube(this);
    }
	// Update is called once per frame
	void Update () {
		
	}

    virtual public void Move()
    {

    }
}
