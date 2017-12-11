using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class S_CuttingStationControls : MonoBehaviour
{
	GameObject gameManager;

	Ray ray;
	RaycastHit hit;
	private float knifeMinX, knifeMaxX, knifeMinY, knifeMaxY, knifeMinZ, knifeMaxZ;
	public bool pickedSomethingUp;
	public bool somethingOnBoard;

	public GameObject pickedUp;
	public GameObject onBoard;
	public GameObject lemon;
	public GameObject banana;
	public GameObject orange;
	public GameObject strawberry;

	public GameObject peeledLemon;
	public GameObject peeledBanana;
	public GameObject peeledOrange;
	public GameObject peeledStrawberry;

	public GameObject slicedLemon;
	public GameObject slicedBanana;
	public GameObject slicedOrange;
	public GameObject slicedStrawberry;

	public Transform dropPosition;
	public Transform lemonStart;
	public Transform bananaStart;
	public Transform orangeStart;
	public Transform strawberryStart;

	public GameObject clearButton;
	public GameObject sliceButton;
	public GameObject peelButton;


	public GameObject knife;
	public Transform knifeStartPosition;
	bool slicing;
	GameObject sliced;

	public bool peeling;
	GameObject peeled;

	// Use this for initialization
	void Start ()
	{
		gameManager = GameObject.Find ("GameManager");
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
				Vector3 touchedPos = GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 3.3f)); // z is how far from camera

				if (Physics.Raycast (ray, out hit, Mathf.Infinity))
				{
					// picking up ingredients
					if (hit.transform.tag == "LemonBowl" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager>().currentLemons > 0)
					{
						print ("Picked up lemon");
						pickedUp = Instantiate (lemon, new Vector3 (lemonStart.transform.position.x, lemonStart.transform.position.y, lemonStart.transform.position.z), Quaternion.identity);
						pickedSomethingUp = true;
						pickedUp.GetComponent<BoxCollider> ().enabled = false;
						// minus 1 lemon from inventory
						gameManager.GetComponent<S_InventoryManager>().currentLemons--;
					}

					if (hit.transform.tag == "BananaBowl" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager>().currentBananas > 0)
					{
						print ("Picked up banana");
						pickedUp = Instantiate (banana, new Vector3 (bananaStart.transform.position.x, bananaStart.transform.position.y, bananaStart.transform.position.z), Quaternion.identity);
						pickedSomethingUp = true;
						pickedUp.GetComponent<BoxCollider> ().enabled = false;
						// minus 1 banana from inventory
						gameManager.GetComponent<S_InventoryManager>().currentBananas--;
					}

					if (hit.transform.tag == "OrangeBowl" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager>().currentOranges > 0)
					{
						print ("Picked up orange");
						pickedUp = Instantiate (orange, new Vector3 (orangeStart.transform.position.x, orangeStart.transform.position.y, orangeStart.transform.position.z), Quaternion.identity);
						pickedSomethingUp = true;
						pickedUp.GetComponent<BoxCollider> ().enabled = false;
						// minus 1 orange from inventory
						gameManager.GetComponent<S_InventoryManager>().currentOranges--;
					}

					if (hit.transform.tag == "StrawberryBowl" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager>().currentStrawberries > 0)
					{
						print ("Picked up strawberry");
						pickedUp = Instantiate (strawberry, new Vector3 (strawberryStart.transform.position.x, strawberryStart.transform.position.y, strawberryStart.transform.position.z), Quaternion.identity);
						pickedSomethingUp = true;
						pickedUp.GetComponent<BoxCollider> ().enabled = false;
						// minus 1 strawberry from inventory
						gameManager.GetComponent<S_InventoryManager>().currentStrawberries--;
					}

					// check to see if peelable ingredient tapped
					if (hit.transform.tag == "Lemon" && peeling == true)
					{
						print ("Peeled lemon");

						peeled = Instantiate(peeledLemon, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.05f, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (0, 0, 0)));
						Destroy (onBoard);
						onBoard = peeled;
					}

					if (hit.transform.tag == "Banana" && peeling == true)
					{
						print ("Peeled banana");

						peeled = Instantiate(peeledBanana, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.03f, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (-90, 0, 45)));
						peeled.transform.rotation = Quaternion.Euler (new Vector3 (0, 90, 0));
						Destroy (onBoard);
						onBoard = peeled;
					}

					if (hit.transform.tag == "Orange" && peeling == true)
					{
						print ("Peeled orange");

						peeled = Instantiate(peeledOrange, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y  + 0.05f, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (-90, 0, 45)));
						Destroy (onBoard);
						onBoard = peeled;
					}

					if (hit.transform.tag == "Strawberry" && peeling == true)
					{
						print ("Peeled strawberry");

						peeled = Instantiate(peeledStrawberry, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.027f, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (-90, 0, 45)));
						Destroy (onBoard);
						onBoard = peeled;
					}
						
					// slicing ingredient on board
					if (hit.transform.tag == "LemonPeeled" && slicing == true)
					{
						print ("Sliced lemon");

						sliced = Instantiate(slicedLemon, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.05f, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (-90, 90, 45)));
						Destroy (onBoard);
						onBoard = sliced;
					}

					if (hit.transform.tag == "BananaPeeled" && slicing == true)
					{
						print ("Sliced banana");

						sliced = Instantiate(slicedBanana, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.015f, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (0, 0, 0)));
						Destroy (onBoard);
						onBoard = sliced;
					}

					if (hit.transform.tag == "OrangePeeled" && slicing == true)
					{
						print ("Sliced orange");

						sliced = Instantiate(slicedOrange, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.01f, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (0, 180, 0)));
						Destroy (onBoard);
						onBoard = sliced;
					}

					if (hit.transform.tag == "StrawberryPeeled" && slicing == true)
					{
						print ("Sliced strawberry");

						sliced = Instantiate(slicedStrawberry, new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.01f, dropPosition.transform.position.z), Quaternion.Euler (new Vector3 (0, 0, 0)));
						Destroy (onBoard);
						onBoard = sliced;
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
							if (pickedUp.transform.tag == "Lemon")
							{
								pickedUp.transform.position = new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.05f, dropPosition.transform.position.z);
							}

							if (pickedUp.transform.tag == "Banana")
							{
								pickedUp.transform.position = new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.03f, dropPosition.transform.position.z);
								pickedUp.transform.rotation = Quaternion.Euler (new Vector3 (0, 90, 0));
							}

							if (pickedUp.transform.tag == "Orange")
							{
								pickedUp.transform.position = new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.05f, dropPosition.transform.position.z);
							}

							if (pickedUp.transform.tag == "Strawberry")
							{
								pickedUp.transform.position = new Vector3 (dropPosition.transform.position.x, dropPosition.transform.position.y + 0.027f, dropPosition.transform.position.z);
							}

							pickedUp.GetComponent<BoxCollider> ().enabled = true;
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
						gameManager.GetComponent<S_InventoryManager> ().currentLemons++; // add one back to lemon count
					}

					if (pickedUp.transform.tag == "Banana") // and it is a banana
					{
						gameManager.GetComponent<S_InventoryManager> ().currentBananas++; // add one back to lemon count
					}

					if (pickedUp.transform.tag == "Orange") // and it is a orange
					{
						gameManager.GetComponent<S_InventoryManager> ().currentOranges++; // add one back to lemon count
					}

					if (pickedUp.transform.tag == "Strawberry") // and it is a strawberry
					{
						gameManager.GetComponent<S_InventoryManager> ().currentStrawberries++; // add one back to lemon count
					}

					Destroy (pickedUp);
					pickedUp = null;
					pickedSomethingUp = false;
				}
			}

			if (somethingOnBoard == true)
			{
				clearButton.SetActive (true);

				// activate peel button
				if (onBoard.transform.tag == "Lemon" || onBoard.transform.tag == "Banana" || onBoard.transform.tag == "Orange" || onBoard.transform.tag == "Strawberry")
				{
					peelButton.SetActive (true);
				}

				// activate slice button
				if (onBoard.transform.tag == "LemonPeeled" || onBoard.transform.tag == "BananaPeeled" || onBoard.transform.tag == "OrangePeeled" || onBoard.transform.tag == "StrawberryPeeled")
				{
					sliceButton.SetActive (true);
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
			knife.transform.position = new Vector3 (knifeStartPosition.transform.position.x, knifeStartPosition.position.y, knifeStartPosition.position.z); // put knife down
		}
	}

	public void ClearBoard ()
	{
		// whole ingredients
		if (onBoard.transform.tag == "Lemon") // and it is a lemon
		{
			gameManager.GetComponent<S_InventoryManager> ().currentLemons++; // add one back to lemon count
		}

		if (onBoard.transform.tag == "Banana") // and it is a banana
		{
			gameManager.GetComponent<S_InventoryManager> ().currentBananas++; // add one back to lemon count
		}

		if (onBoard.transform.tag == "Orange") // and it is a orange
		{
			gameManager.GetComponent<S_InventoryManager> ().currentOranges++; // add one back to lemon count
		}
			
		if (onBoard.transform.tag == "Strawberry") // and it is a strawberry
		{
			gameManager.GetComponent<S_InventoryManager> ().currentStrawberries++; // add one back to lemon count
		}

		// peeled ingredients
		if (onBoard.transform.tag == "LemonPeeled") // and it is a peeled lemon
		{
			gameManager.GetComponent<S_InventoryManager> ().currentPeeledLemons++; // add one to peeled bananas count
		}

		if (onBoard.transform.tag == "BananaPeeled") // and it is a peeled banana
		{
			gameManager.GetComponent<S_InventoryManager> ().currentPeeledBananas++; // add one to peeled bananas count
		}

		if (onBoard.transform.tag == "OrangePeeled") // and it is a peeled orange
		{
			gameManager.GetComponent<S_InventoryManager> ().currentPeeledOranges++; // add one to peeled oranges count
		}

		if (onBoard.transform.tag == "StrawberryPeeled") // and it is a peeled strawberry
		{
			gameManager.GetComponent<S_InventoryManager> ().currentPeeledStrawberries++; // add one to peeled bananas count
		}

		// sliced ingredients
		if (onBoard.transform.tag == "LemonSliced") // and it is a sliced lemon
		{
			gameManager.GetComponent<S_InventoryManager> ().currentSlicedLemons += 7; // add 7 to sliced lemon count
		}

		if (onBoard.transform.tag == "BananaSliced") // and it is a sliced banana
		{
			gameManager.GetComponent<S_InventoryManager> ().currentSlicedBananas += 7; // add 7 to sliced lemon count
		}

		if (onBoard.transform.tag == "OrangeSliced") // and it is a sliced orange
		{
			gameManager.GetComponent<S_InventoryManager> ().currentSlicedOranges += 5; // add 5 to sliced lemon count
		}

		if (onBoard.transform.tag == "StrawberrySliced") // and it is a sliced strawberry
		{
			gameManager.GetComponent<S_InventoryManager> ().currentSlicedStrawberries += 3; // add 3 to sliced strawberries count
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
