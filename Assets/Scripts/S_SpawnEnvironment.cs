using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_SpawnEnvironment : MonoBehaviour
{
	public GameObject enviroment;
	//public GameObject cuttingStation;

	// Use this for initialization
	void Start ()
	{
		SpawnLevel ();
	//	SpawnCuttingStation ();

	}

	void SpawnLevel ()
	{
		Instantiate (enviroment, new Vector3 (0, 0, 0), Quaternion.Euler (new Vector3 (0, -45, 0)));
	}

//	void SpawnCuttingStation()
//	{
//		Instantiate (cuttingStation, new Vector3 (0, 0, -55), Quaternion.Euler (new Vector3 (0, -45, 0)));
//	}
	
	// Update is called once per frame
//	void Update ()
//	{
//		
//	}
}
