using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ShakingStationControls : MonoBehaviour
{
	GameObject gameManager;

	Ray ray;
	RaycastHit hit;

	public bool pickedSomethingUp;
	public GameObject clearButton;
	public GameObject shakeButton;

	public GameObject shakerLidOff;
	public GameObject shakerLidOn;

	public GameObject pickedUp;

	public GameObject lemonTwistJug;
	public GameObject orangeCrushJug;
	public GameObject citrusBurstJug;
	public GameObject bananaBanterJug;
	public GameObject berryBlissJug;
	public GameObject AbominationJug;

	public GameObject lemonTwistUnshakenShaker;
	public GameObject orangeCrushUnshakenShaker;
	public GameObject citrusBurstUnshakenShaker;
	public GameObject bananaBanterUnshakenShaker;
	public GameObject berryBlissUnshakenShaker;
	public GameObject abominationUnshakenShaker;

	public Transform jugStart;

	public GameObject lemonTwist;
	public GameObject orangeCrush;
	public GameObject citrusBurst;
	public GameObject bananaBanter;
	public GameObject berryBliss;
	public GameObject abomination;

	public bool shaking;
	public bool somethingInJug;
	bool somethingInShaker;
	bool shakeable;

	private float holdTime = 3.0f; // time to hold shaker
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
			ray = GetComponent<Camera> ().ScreenPointToRay (Input.GetTouch (0).position);

			Debug.DrawRay (ray.origin, ray.direction * 30, Color.cyan);

			// get the touch position from screen touch to world point
			Vector3 touchedPos = GetComponent<Camera> ().ScreenToWorldPoint (new Vector3 (Input.GetTouch (0).position.x, Input.GetTouch (0).position.y, 1.1f)); // z is how far from camera

			if (Physics.Raycast (ray, out hit, Mathf.Infinity))
			{
				// picking up jug
				if (hit.transform.tag == "UnshakenLemonTwist" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager> ().currentUnshakenLemonTwist > 0)
				{
					print ("Picked up unshaken lemon twist");
					pickedUp = Instantiate (lemonTwistJug, new Vector3 (jugStart.transform.position.x, jugStart.transform.position.y, jugStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;
					pickedUp.GetComponent<BoxCollider> ().enabled = false;
					// minus 1 unshaken lemon twist from inventory
					gameManager.GetComponent<S_InventoryManager> ().currentUnshakenLemonTwist--;
					gameManager.GetComponent<S_InventoryManager> ().unshakenLemonTwistSS.SetActive (false);
				}

				if (hit.transform.tag == "UnshakenOrangeCrush" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager> ().currentUnshakenOrangeCrush > 0)
				{
					print ("Picked up unshaken orange crush");
					pickedUp = Instantiate (orangeCrushJug, new Vector3 (jugStart.transform.position.x, jugStart.transform.position.y, jugStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;
					pickedUp.GetComponent<BoxCollider> ().enabled = false;
					// minus 1 unshaken orange crush from inventory
					gameManager.GetComponent<S_InventoryManager> ().currentUnshakenOrangeCrush--;
					gameManager.GetComponent<S_InventoryManager> ().unshakenOrangeCrushSS.SetActive (false);
				}

				if (hit.transform.tag == "UnshakenCitrusBurst" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager> ().currentUnshakenCitrusBurst > 0)
				{
					print ("Picked up unshaken citrus burst");
					pickedUp = Instantiate (citrusBurstJug, new Vector3 (jugStart.transform.position.x, jugStart.transform.position.y, jugStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;
					pickedUp.GetComponent<BoxCollider> ().enabled = false;
					// minus 1 unshaken citrus burst from inventory
					gameManager.GetComponent<S_InventoryManager> ().currentUnshakenCitrusBurst--;
					gameManager.GetComponent<S_InventoryManager> ().unshakenCitrusBurstSS.SetActive (false);
				}

				if (hit.transform.tag == "UnshakenBananaBanter" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager> ().currentUnshakenBananaBanter> 0)
				{
					print ("Picked up unshaken banana banter");
					pickedUp = Instantiate (bananaBanterJug, new Vector3 (jugStart.transform.position.x, jugStart.transform.position.y, jugStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;
					pickedUp.GetComponent<BoxCollider> ().enabled = false;
					// minus 1 unshaken banana banter from inventory
					gameManager.GetComponent<S_InventoryManager> ().currentUnshakenBananaBanter--;
					gameManager.GetComponent<S_InventoryManager> ().unshakenBananaBanterSS.SetActive (false);
				}

				if (hit.transform.tag == "UnshakenBerryBliss" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager> ().currentUnshakenBerryBliss > 0)
				{
					print ("Picked up unshaken berry bliss");
					pickedUp = Instantiate (berryBlissJug, new Vector3 (jugStart.transform.position.x, jugStart.transform.position.y, jugStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;
					pickedUp.GetComponent<BoxCollider> ().enabled = false;
					// minus 1 unshaken berry bliss from inventory
					gameManager.GetComponent<S_InventoryManager> ().currentUnshakenBerryBliss--;
					gameManager.GetComponent<S_InventoryManager> ().unshakenBerryBlissSS.SetActive (false);
				}

				if (hit.transform.tag == "UnshakenAbomination" && pickedSomethingUp == false && gameManager.GetComponent<S_InventoryManager> ().currentUnshakenAbomination > 0)
				{
					print ("Picked up unshaken abomination");
					pickedUp = Instantiate (AbominationJug, new Vector3 (jugStart.transform.position.x, jugStart.transform.position.y, jugStart.transform.position.z), Quaternion.identity);
					pickedSomethingUp = true;
					pickedUp.GetComponent<BoxCollider> ().enabled = false;
					// minus 1 unshaken abomination from inventory
					gameManager.GetComponent<S_InventoryManager> ().currentUnshakenAbomination--;
					gameManager.GetComponent<S_InventoryManager> ().unshakenAbominationSS.SetActive (false);
				}

				if (pickedUp != null) // if something is picked up
				{
					pickedUp.transform.position = new Vector3 (touchedPos.x, touchedPos.y, touchedPos.z); // move it

					if (hit.transform.tag == "Shaker" && pickedSomethingUp == true && somethingInShaker == false) // drop it in shaker
					{
						if (pickedUp.transform.tag == "UnshakenLemonTwist")
						{
							lemonTwistUnshakenShaker.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenOrangeCrush")
						{
							orangeCrushUnshakenShaker.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenCitrusBurst")
						{
							citrusBurstUnshakenShaker.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenBananaBanter")
						{
							bananaBanterUnshakenShaker.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenBerryBliss")
						{
							berryBlissUnshakenShaker.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenAbomination")
						{
							abominationUnshakenShaker.SetActive (true);
						}

						shakeable = true;
						somethingInShaker = true;
						somethingInJug = false;
						Destroy (pickedUp);
						pickedSomethingUp = false;
						pickedUp = null;
					}
				}

				// check if finger taken off of the screen, if so drop current picked up object
				if (Input.GetTouch (0).phase == TouchPhase.Ended) // if finger is lifted off screen
				{
					if (pickedUp != null) // if something is picked up
					{
						if (pickedUp.transform.tag == "UnshakenLemonTwist") // and it is a lemon twist jug
						{
							gameManager.GetComponent<S_InventoryManager> ().currentUnshakenLemonTwist++; // add one back to lemon twist count
							gameManager.GetComponent<S_InventoryManager> ().unshakenLemonTwistSS.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenOrangeCrush") // and it is a lemon twist jug
						{
							gameManager.GetComponent<S_InventoryManager> ().currentUnshakenOrangeCrush++; // add one back to lemon twist count
							gameManager.GetComponent<S_InventoryManager> ().unshakenOrangeCrushSS.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenCitrusBurst") // and it is a lemon twist jug
						{
							gameManager.GetComponent<S_InventoryManager> ().currentUnshakenCitrusBurst++; // add one back to lemon twist count
							gameManager.GetComponent<S_InventoryManager> ().unshakenCitrusBurstSS.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenBananaBanter") // and it is a lemon twist jug
						{
							gameManager.GetComponent<S_InventoryManager> ().currentUnshakenBananaBanter++; // add one back to lemon twist count
							gameManager.GetComponent<S_InventoryManager> ().unshakenBananaBanterSS.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenBerryBliss") // and it is a lemon twist jug
						{
							gameManager.GetComponent<S_InventoryManager> ().currentUnshakenBerryBliss++; // add one back to lemon twist count
							gameManager.GetComponent<S_InventoryManager> ().unshakenBerryBlissSS.SetActive (true);
						}

						if (pickedUp.transform.tag == "UnshakenAbomination") // and it is a lemon twist jug
						{
							gameManager.GetComponent<S_InventoryManager> ().currentUnshakenAbomination++; // add one back to lemon twist count
							gameManager.GetComponent<S_InventoryManager> ().unshakenAbominationSS.SetActive (true);
						}

						Destroy (pickedUp);
						pickedUp = null;
						pickedSomethingUp = false;
					}
				}


			}


		}

		if (somethingInShaker == true && shakeable == true)
		{
			shakeButton.SetActive (true);
		}

		if (shaking == true)
		{
			// change to shaker lid on
			shakerLidOff.SetActive (false);
			shakerLidOn.SetActive (true);

			// check for touch and hold on shaker for 3 seconds to start shaking
			if (hit.transform.tag == "ShakerLidOn")
			{
				acumTime += Input.GetTouch (0).deltaTime;
				print (acumTime);
				// show vibration

				if (acumTime >= holdTime)
				{
					// switch back to lid off blender
					shakerLidOff.SetActive (true);
					shakerLidOn.SetActive (false);

					shaking = false;
					shakeable = false;

					// add shaken drink to inventory
					if (lemonTwistUnshakenShaker.activeSelf == true) // lemon twist
					{
						//// remove unshaken drink from inventory
						//gameManager.GetComponent<S_InventoryManager> ().currentUnshakenLemonTwist--;

						gameManager.GetComponent<S_InventoryManager> ().currentShakenLemonTwist++;
					}

					if (orangeCrushUnshakenShaker.activeSelf == true) // orange crush
					{
						gameManager.GetComponent<S_InventoryManager> ().currentShakenOrangeCrush++;
					}

					if (citrusBurstUnshakenShaker.activeSelf == true) // citrus burst
					{
						gameManager.GetComponent<S_InventoryManager> ().currentShakenCitrusBurst++;
					}

					if (bananaBanterUnshakenShaker.activeSelf == true) // banana banter
					{
						gameManager.GetComponent<S_InventoryManager> ().currentShakenBananaBanter++;
					}

					if (berryBlissUnshakenShaker.activeSelf == true) // berry bliss
					{
						gameManager.GetComponent<S_InventoryManager> ().currentShakenBerryBliss++;
					}

					if (abominationUnshakenShaker.activeSelf == true) // abomination
					{
						gameManager.GetComponent<S_InventoryManager> ().currentShakenAbomination++;
					}

					if (somethingInShaker == true && shakeable == false)
					{
						shakeButton.SetActive (false);
						clearButton.SetActive (true);
					}
				}

				if (Input.GetTouch (0).phase == TouchPhase.Ended) // if finger is lifted off screen
				{
					acumTime = 0;
				}
			}
		}
	}

	public void ClearShaker()
	{

		if (lemonTwistUnshakenShaker.activeSelf == true) // lemon twist
		{
			lemonTwistUnshakenShaker.SetActive (false);
			lemonTwist.SetActive (true);
		}

		if (orangeCrushUnshakenShaker.activeSelf == true) // orange crush
		{
			orangeCrushUnshakenShaker.SetActive (false);
			orangeCrush.SetActive (true);
		}

		if (citrusBurstUnshakenShaker.activeSelf == true) // citrus burst
		{
			citrusBurstUnshakenShaker.SetActive (false);
			citrusBurst.SetActive (true);
		}

		if (bananaBanterUnshakenShaker.activeSelf == true) // banana banter
		{
			bananaBanterUnshakenShaker.SetActive (false);
			bananaBanter.SetActive (true);
		}

		if (berryBlissUnshakenShaker.activeSelf == true) // berry bliss
		{
			berryBlissUnshakenShaker.SetActive (false);
			berryBliss.SetActive (true);
		}

		if (abominationUnshakenShaker.activeSelf == true) // abomination
		{
			abominationUnshakenShaker.SetActive (false);
			abomination.SetActive (true);
		}

		// hide clear button
		clearButton.SetActive(false);
	}

	public void Shake()
	{
		shaking = true;
	}
}
