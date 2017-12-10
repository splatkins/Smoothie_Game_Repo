using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CustomerMovement : MonoBehaviour
{
	bool doorReached, gotABarPoint;
	public bool barReached;

	public Vector3 doorPosition = new Vector3 ();

	public float speed;
	Vector3 chosenBarPoint = new Vector3();

	bool madeRequest;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		// pick a bar point
		ChooseBarPoint();

		float step = speed * Time.deltaTime;

		if (doorReached == false)
		{
			transform.position = Vector3.MoveTowards (transform.position, doorPosition, step);

			if (transform.position == doorPosition)
			{
				doorReached = true;
			}
		}

		if (doorReached == true)
		{
			transform.position = Vector3.MoveTowards (transform.position, chosenBarPoint, step);

			if (transform.position == chosenBarPoint)
			{
				barReached = true;
			}
		}

		// check if at bar
		if (barReached == true && madeRequest == false)
		{
			// make request
			this.GetComponent<S_CustomerGeneration>().MakeRquest();
			madeRequest = true;
		}
	}

	void ChooseBarPoint()
	{
		int randomBarPoint = Random.Range (0, 4);
		if (gotABarPoint == false)
		{
			switch (randomBarPoint)
			{
//			case 5:
//				if (GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint6InUse == true)
//				{
//					break;
//				}
//				chosenBarPoint = GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoints [5];
//				GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint6InUse = true;
//				gotABarPoint = true;
//				break;
//			case 4:
//				if (GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint5InUse == true)
//				{
//					break;
//				}
//				chosenBarPoint = GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoints [4];
//				GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint5InUse = true;
//				gotABarPoint = true;
//				break;
//			case 3:
//				if (GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint4InUse == true)
//				{
//					break;
//				}
//				chosenBarPoint = GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoints [3];
//				GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint4InUse = true;
//				gotABarPoint = true;
//				break;
			case 2:
				if (GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint3InUse == true)
				{
					break;
				}
				chosenBarPoint = GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoints [2];
				GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint3InUse = true;
				gotABarPoint = true;
				break;
			case 1:
				if (GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint2InUse == true)
				{
					break;
				}
				chosenBarPoint = GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoints [1];
				GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint2InUse = true;
				gotABarPoint = true;
				break;
			case 0:
				if (GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint1InUse == true)
				{
					break;
				}
				chosenBarPoint = GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoints [0];
				GameObject.Find ("GameManager").GetComponent<S_BarController> ().barPoint1InUse = true;
				gotABarPoint = true;
				break;
			default:
				print ("Customer did not choose a bar point");
				break;
			}
		}

		//print ("chosen bar point " + chosenBarPoint);
	}
}
