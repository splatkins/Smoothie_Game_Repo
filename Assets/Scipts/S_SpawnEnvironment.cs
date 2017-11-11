using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_SpawnEnvironment : MonoBehaviour
{
	public GameObject enviroment;

	// Use this for initialization
	void Start ()
	{
		Instantiate (enviroment, new Vector3 (0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
//	void Update ()
//	{
//		
//	}
}
