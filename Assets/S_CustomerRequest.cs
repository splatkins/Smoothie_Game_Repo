using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CustomerRequest : MonoBehaviour
{


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		// check if at bar
		if (this.GetComponent<S_CustomerMovement> ().barReached == true)
		{
			// make request


		}
	}
}
