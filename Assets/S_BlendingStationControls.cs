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

	public GameObject blenderLidOff;
	public GameObject blenderLidOn;

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
	public bool blending;
	bool somethingInBlender;

	private float holdTime = 3.0f; // time to hold blender
	private float acumTime = 0;

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

					if(hit.transform.tag == "Blender" && pickedSomethingUp == true && somethingInBlender == false) // drop it in blender
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
					blenderLidOff.SetActive (false);
					blenderLidOn.SetActive (true);

					// check for touch and hold on blender for 3 seconds to start blending
					if (hit.transform.tag == "BlenderLidOn")
					{
						acumTime += Input.GetTouch (0).deltaTime;
						print (acumTime);
						// show vibration

						if (acumTime >= holdTime)
						{
							// switch back to lid off blender
							blenderLidOff.SetActive (true);
							blenderLidOn.SetActive (false);

							blending = false;
							// hide vibration

							// add unshaken drink to inventory
							if (makeableDrinkImage.GetComponent<Image> ().sprite == makeableDrinks [0]) // lemon twist
							{
								// show unshaken drink
								gameManager.GetComponent<S_InventoryManager> ().currentUnshakenLemonTwist++;
								gameManager.GetComponent<S_InventoryManager>().unshakenLemonTwistBS.SetActive(true);
								somethingInBlender = true;

								// remove blender ingredient contents
								lemonSliceCount -= 14;
								iceCount -= 3;
							}

							if (makeableDrinkImage.GetComponent<Image> ().sprite == makeableDrinks [1]) // orange crush
							{
								// show unshaken drink
								gameManager.GetComponent<S_InventoryManager> ().currentUnshakenOrangeCrush++;
								gameManager.GetComponent<S_InventoryManager>().unshakenOrangeCrushBS.SetActive(true);
								somethingInBlender = true;

								// remove blender ingredient contents
								orangeSliceCount -= 15;
								iceCount -= 3;
							}

							if (makeableDrinkImage.GetComponent<Image> ().sprite == makeableDrinks [2]) // citrus burst
							{
								// show unshaken drink
								gameManager.GetComponent<S_InventoryManager> ().currentUnshakenCitrusBurst++;
								gameManager.GetComponent<S_InventoryManager>().unshakenCitrusBurstBS.SetActive(true);
								somethingInBlender = true;

								// remove blender ingredient contents
								lemonSliceCount -= 7;
								orangeSliceCount -= 10;
							}

							if (makeableDrinkImage.GetComponent<Image> ().sprite == makeableDrinks [3]) // banana banter
							{
								// show unshaken drink
								gameManager.GetComponent<S_InventoryManager> ().currentUnshakenBananaBanter++;
								gameManager.GetComponent<S_InventoryManager>().unshakenBananaBanterBS.SetActive(true);
								somethingInBlender = true;

								// remove blender ingredient contents
								bananaSliceCount -= 21;
							}

							if (makeableDrinkImage.GetComponent<Image> ().sprite == makeableDrinks [4]) // berry bliss
							{
								// show unshaken drink
								gameManager.GetComponent<S_InventoryManager> ().currentUnshakenBerryBliss++;
								gameManager.GetComponent<S_InventoryManager>().unshakenBerryBlissBS.SetActive(true);
								somethingInBlender = true;

								// remove blender ingredient contents
								strawberrySliceCount -= 9;
								iceCount -= 3;
							}

							if (makeableDrinkImage.GetComponent<Image> ().sprite == makeableDrinks [5]) // abomination
							{
								// show unshaken drink
								gameManager.GetComponent<S_InventoryManager> ().currentUnshakenAbomination++;
								gameManager.GetComponent<S_InventoryManager>().unshakenAbominationBS.SetActive(true);
								somethingInBlender = true;

								// remove blender ingredient contents
								lemonSliceCount -= 7;
								bananaSliceCount -= 7;
								orangeSliceCount -= 5;
								strawberrySliceCount -= 3;
							}


						}

						if (Input.GetTouch (0).phase == TouchPhase.Ended) // if finger is lifted off screen
						{
							acumTime = 0;
						}
					}




					// after held 3 secs change to lid off blender and hide jug
					// enable shaking station jug
				}
			}
		}

		// show clear button if something in blender
		if (lemonSliceCount > 0 || bananaSliceCount > 0 || orangeSliceCount > 0 || strawberrySliceCount > 0 || iceCount > 0 || somethingInBlender == true)
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
			//print("Can make lemon twist");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[0];
			canMakeNothing = false;
			blendButton.SetActive(true);
		}
		else if (lemonSliceCount == 0 && bananaSliceCount == 0 && orangeSliceCount == 15 && strawberrySliceCount == 0 && iceCount == 3)
		{
			// can make orange crush
			//print("Can make orange crush");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[1];
			canMakeNothing = false;
			blendButton.SetActive(true);
		}
		else if (lemonSliceCount == 7 && bananaSliceCount == 0 && orangeSliceCount == 10 && strawberrySliceCount == 0 && iceCount == 0)
		{
			// can make citrus burst
			//print("Can make citrus burst");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[2];
			canMakeNothing = false;
			blendButton.SetActive(true);
		}
		else if (lemonSliceCount == 0 && bananaSliceCount == 21 && orangeSliceCount == 0 && strawberrySliceCount == 0 && iceCount == 0)
		{
			// can make banana banter
			//print("Can make banana banter");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[3];
			canMakeNothing = false;
			blendButton.SetActive(true);
		}
		else if (lemonSliceCount == 0 && bananaSliceCount == 0 && orangeSliceCount == 0 && strawberrySliceCount == 9 && iceCount == 3)
		{
			// can make berry bliss
			//print("Can make berry bliss");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[4];
			canMakeNothing = false;
			blendButton.SetActive(true);
		}
		else if (lemonSliceCount == 7 && bananaSliceCount == 7 && orangeSliceCount == 5 && strawberrySliceCount == 3 && iceCount == 0)
		{
			// can make abomination
			//sprint("Can make abomination");
			makeableDrinkImage.enabled = true;
			makeableDrinkImage.GetComponent<Image>().sprite = makeableDrinks[5];
			canMakeNothing = false;
			blendButton.SetActive(true);
		}
		else
		{
			// can make nothing
			makeableDrinkImage.GetComponent<Image>().enabled = false;
			blendButton.SetActive (false);
		}

//		if (canMakeNothing == false)
//		{
//			// show blend button if something can be made
//			blendButton.SetActive(true);
//		}

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

		// clear made drink to shaking station blender
		if(gameManager.GetComponent<S_InventoryManager>().currentUnshakenLemonTwist == 1) // drink is berry bliss
		{
			//unshakenBerryBlissSS.SetActive (true);
			gameManager.GetComponent<S_InventoryManager>().unshakenLemonTwistBS.SetActive(false);
			gameManager.GetComponent<S_InventoryManager>().unshakenLemonTwistSS.SetActive(true);

			somethingInBlender = false;
		}

		if(gameManager.GetComponent<S_InventoryManager>().currentUnshakenOrangeCrush == 1) // drink is orange crush
		{
			//unshakenBerryBlissSS.SetActive (true);
			gameManager.GetComponent<S_InventoryManager>().unshakenOrangeCrushBS.SetActive(false);
			gameManager.GetComponent<S_InventoryManager>().unshakenOrangeCrushSS.SetActive(true);

			somethingInBlender = false;
		}

		if(gameManager.GetComponent<S_InventoryManager>().currentUnshakenCitrusBurst == 1) // drink is citrus burst
		{
			//unshakenBerryBlissSS.SetActive (true);
			gameManager.GetComponent<S_InventoryManager>().unshakenCitrusBurstBS.SetActive(false);
			gameManager.GetComponent<S_InventoryManager>().unshakenCitrusBurstSS.SetActive(true);

			somethingInBlender = false;
		}

		if(gameManager.GetComponent<S_InventoryManager>().currentUnshakenBananaBanter == 1) // drink is banana banter
		{
			//unshakenBerryBlissSS.SetActive (true);
			gameManager.GetComponent<S_InventoryManager>().unshakenBananaBanterBS.SetActive(false);
			gameManager.GetComponent<S_InventoryManager>().unshakenBananaBanterSS.SetActive(true);

			somethingInBlender = false;
		}

		if(gameManager.GetComponent<S_InventoryManager>().currentUnshakenBerryBliss == 1) // drink is berry bliss
		{
			//unshakenBerryBlissSS.SetActive (true);
			gameManager.GetComponent<S_InventoryManager>().unshakenBerryBlissBS.SetActive(false);
			gameManager.GetComponent<S_InventoryManager>().unshakenBerryBlissSS.SetActive(true);

			somethingInBlender = false;
		}

		if(gameManager.GetComponent<S_InventoryManager>().currentUnshakenAbomination == 1) // drink is abomination
		{
			//unshakenBerryBlissSS.SetActive (true);
			gameManager.GetComponent<S_InventoryManager>().unshakenAbominationBS.SetActive(false);
			gameManager.GetComponent<S_InventoryManager>().unshakenAbominationSS.SetActive(true);

			somethingInBlender = false;
		}

		clearButton.SetActive (false);
		blendButton.SetActive (false);
		canMakeNothing = true;
	}

	public void Blend()
	{
		blending = true;

	}





}
