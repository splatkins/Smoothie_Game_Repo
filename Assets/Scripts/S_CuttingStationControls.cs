using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class S_CuttingStationControls : MonoBehaviour
{
	Ray ray;
	RaycastHit hit;
	private float knifeMinX, knifeMaxX, knifeMinY, knifeMaxY, knifeMinZ, knifeMaxZ;
	public bool pickedSomethingUp;
	public bool somethingOnBoard;

	public GameObject pickedUp;
	public GameObject onBoard;
	public GameObject lemon;
	public GameObject strawberry;
	public GameObject banana;
	public GameObject orange;

	public GameObject slicedLemon;
	public GameObject slicedStrawberry;
	public GameObject peeledBanana;
	public GameObject peeledOrange;

	public Transform dropPosition;
	public Transform lemonStart;
	public Transform strawberryStart;
	public Transform bananaStart;
	public Transform orangeStart;

	public GameObject clearButton;
	public GameObject sliceButton;
	public GameObject peelButton;

	bool slicing;
	public GameObject knife;
	public Transform knifeStartPosition;
	GameObject sliced;

	public bool peeling;
	GameObject peeled;

	// Use this for initialization
	void Start ()
	{
//		knifeMinX = -0.46f;
//		knifeMaxX = 0.42f;
//		knifeMinY = 6.65f;
//		knifeMaxY = 6.65f;
//		knifeMinZ = -0.64f;
//		knifeMaxZ = 0.15f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		// check if there are touches
		if (Input.touchCount > 0)
		{
			// check to see if 
			if (Input.GetTouch (0).phase == TouchPhase.Began || Input.GetTouch (0).phase == TouchPhase.Stationary || Input.GetTouch (0).phase == TouchPhase.Moved)
			{
				ray = GetComponent<Camera>().ScreenPointToRay (Input.GetTouch (0).position);

				Debug.DrawRay (ray.origin, ray.direction * 30, Color.cyan);

				// get the touch position from screen touch to world point
				Vector3 touchedPos = GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 5.6f));

				if (Physics.Raycast (ray, out hit, Mathf.Infinity))
				{
					// picking up ingredients
					if (hit.transform.tag == "LemonBowl" && pickedSomethingUp == false && GameObject.Find("InventoryManager").GetComponent<S_InventoryManager>().currentLemons > 0)
					{
						print ("Picked up lemon");
						pickedUp = Instantiate (lemon, new Vector3 (lemonStart.transform.position.x, lemonStart.transform.position.y, lemonStart.transform.position.z), Quaternion.identity);
						pickedSomethingUp = true;

						// minus 1 lemon from inventory
						GameObject.Find("InventoryManager").GetComponent<S_InventoryManager>().currentLemons--;
					}

					if (hit.transform.tag == "StrawberryBowl" && pickedSomethingUp == false && GameObject.Find("InventoryManager").GetComponent<S_InventoryManager>().currentStrawberries > 0)
					{
						print ("Picked up strawberry");
						pickedUp = Instantiate (strawberry, new Vector3 (strawberryStart.transform.position.x, strawberryStart.transform.position.y, strawberryStart.transform.position.z), Quaternion.identity);
						pickedSomethingUp = true;

						// minus 1 strawberry from inventory
						GameObject.Find("InventoryManager").GetComponent<S_InventoryManager>().currentStrawberries--;
					}

					if (hit.transform.tag == "BananaBowl" && pickedSomethingUp == false && GameObject.Find("InventoryManager").GetComponent<S_InventoryManager>().currentBananas > 0)
					{
						print ("Picked up banana");
						pickedUp = Instantiate (banana, new Vector3 (bananaStart.transform.position.x, bananaStart.transform.position.y, bananaStart.transform.position.z), Quaternion.identity);
						pickedSomethingUp = true;

						// minus 1 banana from inventory
						GameObject.Find("InventoryManager").GetComponent<S_InventoryManager>().currentBananas--;
					}

					if (hit.transform.tag == "OrangeBowl" && pickedSomethingUp == false && GameObject.Find("InventoryManager").GetComponent<S_InventoryManager>().currentOranges > 0)
					{
						print ("Picked up orange");
						pickedUp = Instantiate (orange, new Vector3 (orangeStart.transform.position.x, orangeStart.transform.position.y, orangeStart.transform.position.z), Quaternion.identity);
						pickedSomethingUp = true;

						// minus 1 orange from inventory
						GameObject.Find("InventoryManager").GetComponent<S_InventoryManager>().currentOranges--;
					}

					// slicing ingredient on board
					if (hit.transform.tag == "Lemon" && slicing == true)
					{
						print ("Sliced lemon");

						sliced = Instantiate(slicedLemon, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (-90, 0, 45)));
						Destroy (onBoard);
						onBoard = sliced;
					}

					if (hit.transform.tag == "Strawberry" && slicing == true)
					{
						print ("Sliced strawberry");

						sliced = Instantiate(slicedStrawberry, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (-90, 0, 45)));
						Destroy (onBoard);
						onBoard = sliced;
					}

					// check to see if peelable ingredient tapped
					if (hit.transform.tag == "Banana" && peeling == true)
					{
						print ("Peeled banana");

						peeled = Instantiate(peeledBanana, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (-90, 0, 45)));
						Destroy (onBoard);
						onBoard = peeled;
					}

					if (hit.transform.tag == "Orange" && peeling == true)
					{
						print ("Peeled orange");

						peeled = Instantiate(peeledOrange, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (-90, 0, 45)));
						Destroy (onBoard);
						onBoard = peeled;
					}

					if (hit.transform.tag == "CuttingBoard" && slicing == true)
					{
						knife.transform.position = new Vector3 (touchedPos.x, touchedPos.y, touchedPos.z); // move knife

						//					knife.transform.localPosition = new Vector3 (
						//						Mathf.Clamp(touchedPos.x, knifeMinX, knifeMaxX),
						//						Mathf.Clamp(touchedPos.y, knifeMinY, knifeMaxY),
						//						Mathf.Clamp(touchedPos.z, knifeMinZ, knifeMaxZ)); // move knife
					}

					if (pickedUp != null) // if something is picked up
					{
						pickedUp.transform.position = new Vector3 (touchedPos.x, touchedPos.y, touchedPos.z); // move it

						if(hit.transform.tag == "CuttingBoard" && pickedSomethingUp == true && somethingOnBoard == false) // drop it on board
						{
							pickedUp.transform.position = new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y, dropPosition.transform.position.z);
							somethingOnBoard = true;
							onBoard = pickedUp;
							pickedSomethingUp = false;
							pickedUp = null;
						}
					}
				}



			}

			// check if finger taken off of the screen, if so drop current picked up object
			if (Input.GetTouch (0).phase == TouchPhase.Ended) // if finger is lifted off screen
			{
				if (pickedUp != null) // if something is picked up
				{
					if (pickedUp.transform.tag == "Lemon") // and it is a lemon
					{
						GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentLemons++; // add one back to lemon count
					}

					if (pickedUp.transform.tag == "Strawberry") // and it is a strawberry
					{
						GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentStrawberries++; // add one back to lemon count
					}

					if (pickedUp.transform.tag == "Banana") // and it is a banana
					{
						GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentBananas++; // add one back to lemon count
					}

					if (pickedUp.transform.tag == "Orange") // and it is a orange
					{
						GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentOranges++; // add one back to lemon count
					}

					Destroy (pickedUp);
					pickedUp = null;
					pickedSomethingUp = false;
				}
			}

			if (somethingOnBoard == true)
			{
				clearButton.SetActive (true);

				// activate slice button
				if (onBoard.transform.tag == "Lemon" || onBoard.transform.tag == "Strawberry")
				{
					sliceButton.SetActive (true);
				}

				// activate peel button
				if (onBoard.transform.tag == "Banana" || onBoard.transform.tag == "Orange")
				{
					peelButton.SetActive (true);
				}
			}
			else
			{
				clearButton.SetActive (false);
				sliceButton.SetActive (false);
				peelButton.SetActive (false);
			}
				
		}

		if (slicing == false)
		{
			//print ("Deactivate knife");
			knife.transform.position = new Vector3 (knifeStartPosition.transform.position.x, knifeStartPosition.position.y, knifeStartPosition.position.z);
		}
	}

	public void ClearBoard ()
	{
		if (onBoard.transform.tag == "Lemon") // and it is a lemon
		{
			GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentLemons++; // add one back to lemon count
		}

		if (onBoard.transform.tag == "Strawberry") // and it is a strawberry
		{
			GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentStrawberries++; // add one back to lemon count
		}

		if (onBoard.transform.tag == "Banana") // and it is a banana
		{
			GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentBananas++; // add one back to lemon count
		}

		if (onBoard.transform.tag == "Orange") // and it is a orange
		{
			GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentOranges++; // add one back to lemon count
		}

		if (onBoard.transform.tag == "SlicedLemon") // and it is a sliced lemon
		{
			GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentSlicedLemons++; // add one to sliced lemon count
		}

		if (onBoard.transform.tag == "SlicedStrawberry") // and it is a sliced strawberry
		{
			GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentSlicedStrawberries++; // add one to sliced strawberries count
		}

		if (onBoard.transform.tag == "PeeledBanana") // and it is a peeled banana
		{
			GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentPeeledBananas++; // add one to peeled bananas count
		}

		if (onBoard.transform.tag == "PeeledOrange") // and it is a sliced strawberry
		{
			GameObject.Find ("InventoryManager").GetComponent<S_InventoryManager> ().currentPeeledOranges++; // add one to peeled oranges count
		}

		Destroy (onBoard);
		onBoard = null;
		somethingOnBoard = false;

		if (slicing == true)
		{
			slicing = !slicing;
		}

		if (peeling == true)
		{
			peeling = !peeling;
		}
	}

	public void Slice ()
	{
		slicing = true;

		// activate knife
		knife.transform.Translate(-0.3f, 0.3f, 0f);
	}

	public void Peel()
	{
		peeling = true;
	}
}
