using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CustomerMovement : MonoBehaviour
{

	public Vector3 doorPosition = new Vector3 ();
	public List<Vector3> barPoints = new List<Vector3> ();

	// Use this for initialization
	void Start ()
	{
		// pick a bar point
		int randomBarPoint = Random.Range (0, 7);
		Vector3 chosenBarPoint = new Vector3();

		switch (randomBarPoint)
		{
		case 5:
			chosenBarPoint = barPoints [5];
			break;
		case 4:
			chosenBarPoint = barPoints [5];//////////////////////////////////////////////////////
			break;
		case 3:

			break;
		case 2:

			break;
		case 1:
			
			break;
		case 0:
			
			break;
		default:
			print ("Customer did not choose a bar point");
			break;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
