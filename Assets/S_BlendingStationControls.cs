using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_BlendingStationControls : MonoBehaviour
{
	GameObject gameManager;

	Ray ray;
	RaycastHit hit;

	public bool pickedSomethingUp;
	public GameObject clearButton;
	public GameObject blendButton;

	public GameObject pickedUp;

	// individual ingredient slices
	public GameObject lemonSlice;
	public GameObject bananaSlice;
	public GameObject orangeSlice;
	public GameObject strawberrySlice;
	public GameObject ice;

	public Transform lemonSliceStart;
	public Transform bananaSliceStart;
	public Transform orangeSliceStart;
	public Transform strawberrySliceStart;
	public Transform iceStart;

//	public List<GameObject> inBlender = new List<GameObject>();
	public int lemonSliceCount;
	public int bananaSliceCount;
	public int orangeSliceCount;
	public int strawberrySliceCount;
	public int iceCount;

	public Image makeableDrinkImage;
	public List<Sprite> makeableDrinks = new List<Sprite>();
	bool canMakeNothing = true;
	bool blending;

	// Use this for initialization
	void Start ()
	{
		gameManager = GameObject.Find ("GameManager");
	}
	
	// Update is called once per frame
	void Update ()
	{
		// check if there are touches
		if (Input.touchCount > 0)
		{
			ray = GetComponent<Camera>().ScreenPointToRay (Input.GetTouch (0).position);

			Debug.DrawRay (ray.origin, ray.direction * 30, Color.cyan);

			// get the touch position from screen touch to world point
			Vector3 touchedPos = GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 2.1f)); // z is how far from camera

			if (Physics.Raycast (ray, out hit, Mathf.Infinity))
			{
				// picking up ingredients
				if (hit.transform.tag == "LemonSliceBowl" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager>().currentSlicedLemons > 0)
				{
					print ("Picked up slice of lemon");
					pickedUp = Instantiate (lemonSlice, new Vector3 (lemonSliceStart.transform.position.x, lemonSliceStart.transform.position.y, lemonSliceStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;

					// minus 1 lemon from inventory
					gameManager.GetComponent<S_InventoryManager>().currentSlicedLemons--;
				}

				if (hit.transform.tag == "BananaSliceBowl" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager>().currentSlicedBananas > 0)
				{
					print ("Picked up slice of banana");
					pickedUp = Instantiate (bananaSlice, new Vector3 (bananaSliceStart.transform.position.x, bananaSliceStart.transform.position.y, bananaSliceStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;

					// minus 1 banana from inventory
					gameManager.GetComponent<S_InventoryManager>().currentSlicedBananas--;
				}

				if (hit.transform.tag == "OrangeSliceBowl" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager>().currentSlicedOranges > 0)
				{
					print ("Picked up slice of orange");
					pickedUp = Instantiate (orangeSlice, new Vector3 (orangeSliceStart.transform.position.x, orangeSliceStart.transform.position.y, orangeSliceStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;

					// minus 1 orange from inventory
					gameManager.GetComponent<S_InventoryManager>().currentSlicedOranges--;
				}

				if (hit.transform.tag == "StrawberrySliceBowl" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager>().currentSlicedStrawberries > 0)
				{
					print ("Picked up slice of strawberry");
					pickedUp = Instantiate (strawberrySlice, new Vector3 (strawberrySliceStart.transform.position.x, strawberrySliceStart.transform.position.y, strawberrySliceStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;

					// minus 1 strawberry from inventory
					gameManager.GetComponent<S_InventoryManager>().currentSlicedStrawberries--;
				}

				if (hit.transform.tag == "IceBowl" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager>().currentIce > 0)
				{
					print ("Picked up ice cube");
					pickedUp = Instantiate (ice, new Vector3 (iceStart.transform.position.x, iceStart.transform.position.y, iceStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;

					// minus 1 strawberry from inventory
					gameManager.GetComponent<S_InventoryManager>().currentIce--;
				}

				if (pickedUp != null) // if something is picked up
				{
					pickedUp.transform.position = new Vector3 (touchedPos.x, touchedPos.y, touchedPos.z); // move it

					if(hit.transform.tag == "Blender" && pickedSomethingUp == true) // drop it in blender
					{
						if (pickedUp.transform.tag == "LemonSlice")
						{
							lemonSliceCount++;
						}

						if (pickedUp.transform.tag == "BananaSlice")
						{
							bananaSliceCount++;
						}

						if (pickedUp.transform.tag == "OrangeSlice")
						{
							orangeSliceCount++;
						}

						if (pickedUp.transform.tag == "StrawberrySlice")
						{
							strawberrySliceCount++;
						}

						if (pickedUp.transform.tag == "Ice")
						{
							iceCount++;
						}

						//inBlender.Add (pickedUp);
						//pickedUp.GetComponent<MeshRenderer> ().enabled = false;

						Destroy (pickedUp);
						pickedSomethingUp = false;
						pickedUp = null;
					}

					// check if finger taken off of the screen, if so drop current picked up object
					if (Input.GetTouch (0).phase == TouchPhase.Ended) // if finger is lifted off screen
					{
						if (pickedUp != null) // if something is picked up
						{
							if (pickedUp.transform.tag == "LemonSlice") // and it is a lemon slice
							{
								gameManager.GetComponent<S_InventoryManager> ().currentSlicedLemons++; // add one back to sliced lemon count
							}

							if (pickedUp.transform.tag == "BananaSlice") // and it is a banana slice
							{
								gameManager.GetComponent<S_InventoryManager> ().currentSlicedBananas++; // add one back to sliced banana count
							}

							if (pickedUp.transform.tag == "OrangeSlice") // and it is a orange slice
							{
								gameManager.GetComponent<S_InventoryManager> ().currentSlicedOranges++; // add one back to sliced orange count
							}

							if (pickedUp.transform.tag == "StrawberrySlice") // and it is a strawberry slice
							{
								gameManager.GetComponent<S_InventoryManager> ().currentSlicedStrawberries++; // add one back to sliced strawberry count
							}

							if (pickedUp.transform.tag == "Ice") // and it is a strawberry slice
							{
								gameManager.GetComponent<S_InventoryManager> ().currentIce++; // add one back to sliced strawberry count
							}

							Destroy (pickedUp);
							pickedUp = null;
							pickedSomethingUp = false;
						}
					}
				}

				if (blending == true)
				{
					// change to blender lid on
					// check for touch and hold on blender for 3 seconds
					// display vibation while holding

					// after held 3 secs change to lid off blender and hide jug
					// enable shaking station jug
				}
			}
		}

		// show clear button if something in blender
		if (lemonSliceCount > 0 || bananaSliceCount > 0 || orangeSliceCount > 0 || strawberrySliceCount > 0 || iceCount > 0)
		{
			clearButton.SetActive (true);
		}
		else
		{
			clearButton.SetActive (false);
			blendButton.SetActive (false);
		}

		// check if blender contents make a drink
		if (lemonSliceCount == 14 && bananaSliceCount == 0 && orangeSliceCount == 0 && strawberrySliceCount == 0 && iceCount == 3)
		{
			// can make lemon twist
			print("Can make lemon twist");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[0];
			canMakeNothing = false;
		}
		else if (lemonSliceCount == 0 && bananaSliceCount == 0 && orangeSliceCount == 15 && strawberrySliceCount == 0 && iceCount == 3)
		{
			// can make orange crush
			print("Can make orange crush");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[1];
			canMakeNothing = false;
		}
		else if (lemonSliceCount == 7 && bananaSliceCount == 0 && orangeSliceCount == 10 && strawberrySliceCount == 0 && iceCount == 0)
		{
			// can make citrus burst
			print("Can make citrus burst");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[2];
			canMakeNothing = false;
		}
		else if (lemonSliceCount == 0 && bananaSliceCount == 21 && orangeSliceCount == 0 && strawberrySliceCount == 0 && iceCount == 0)
		{
			// can make banana banter
			print("Can make banana banter");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[3];
			canMakeNothing = false;
		}
		else if (lemonSliceCount == 0 && bananaSliceCount == 0 && orangeSliceCount == 0 && strawberrySliceCount == 9 && iceCount == 3)
		{
			// can make berry bliss
			print("Can make berry bliss");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[4];
			canMakeNothing = false;
		}
		else if (lemonSliceCount == 7 && bananaSliceCount == 7 && orangeSliceCount == 5 && strawberrySliceCount == 3 && iceCount == 0)
		{
			// can make abomination
			print("Can make abomination");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[5];
			canMakeNothing = false;
		}
		else
		{
			// can make nothing
			makeableDrinkImage.GetComponent<Image>().enabled = false;
		}

		if (canMakeNothing == false)
		{
			// show blend button if something can be made
			blendButton.SetActive(true);
		}

		makeableDrinkImage.preserveAspect = true;
	}

	public void ClearBlender()
	{
		gameManager.GetComponent<S_InventoryManager> ().currentSlicedLemons += lemonSliceCount;
		lemonSliceCount = 0;
	
		gameManager.GetComponent<S_InventoryManager> ().currentSlicedBananas += bananaSliceCount;
		bananaSliceCount = 0;

		gameManager.GetComponent<S_InventoryManager> ().currentSlicedOranges += orangeSliceCount;
		orangeSliceCount = 0;

		gameManager.GetComponent<S_InventoryManager> ().currentSlicedStrawberries += strawberrySliceCount;
		strawberrySliceCount = 0;

		gameManager.GetComponent<S_InventoryManager> ().currentIce += iceCount;
		iceCount = 0;

		clearButton.SetActive (false);
		canMakeNothing = true;
	}

	public void Blend()
	{
		blending = true;

	}





}
