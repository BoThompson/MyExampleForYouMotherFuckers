using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

    public List<Cube> Cubes;
    public static CubeManager Instance { get; private set; }
	// Use this for initialization
	void Start () {
        if (Instance == null)
            Instance = this;
	}
	
    public void RegisterCube(Cube cube)
    {
        Cubes.Add(cube);
    }

    public void DeregisterCube(Cube cube)
    {
        Cubes.Remove(cube);
    }

    void DestroyAllCubes()
    {
        foreach (Cube cube in Cubes)
        {
            Destroy(cube.gameObject);
        }
    }

    void MoveCubes()
    {
        foreach (Cube cube in Cubes)
        {
            cube.Move();
        }
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveCubes();
        }

        if (Input.GetKeyDown(KeyCode.Return))
            DestroyAllCubes();
	}
}
