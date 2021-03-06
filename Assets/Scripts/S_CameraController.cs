﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CameraController : MonoBehaviour
{
	// zoom speeds
	public float perspectiveZoonSpeed = 0.5f;
	float orthoZoomSpeed = 0.5f;

	private float minX, maxX, minZ, maxZ;
	//private Vector3 myPosition;
	public float panSpeed = 0.5f;

	Ray ray;
	RaycastHit hit;

	public Camera worldCam;
	public Camera menuStationCam;
	public Camera cuttingStationCam;
	public Camera blendingStationCam;
	public Camera shakingStationCam;

	public Canvas menuStationCanvas;
	public Canvas cuttingStationCanvas;
	public Canvas blendingStationCanvas;
	public Canvas shakingStaionCanvas;

	public GameObject cuttingStationControls;
	public GameObject blendingStationControls;
	public GameObject shakingStationControls;

	public GameObject cuttingStationCollider;
	public GameObject blendingStationCollider;
	public GameObject shakingStationCollider;

	bool canMoveWorldCam;


	// Use this for initialization
	void Start ()
	{
		ShowWorldCam ();
	//	cuttingStationCam = GameObject.FindWithTag ("CuttingStationCamera");

		minX = -1.47f; //-6f;
		maxX = 2.8f; //5.1f;
		minZ = -7.5f; //-12.3f;
		maxZ = -0.25f; //1.4f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//myPosition = transform.position;

		// check if there are touches
		if (Input.touchCount > 0)
		{
			if (canMoveWorldCam == true)
			{
				CameraControls ();
			}
		}

		//AssignCameras ();
	}

//	void AssignCameras()
//	{
//		
//		cuttingStationCam = GameObject.Find ("CutingStationCamera").GetComponent<Camera> ();
//		blendingStationCam = GameObject.Find ("BlendingStationCamera").GetComponent<Camera> ();
//		shakingStationCam = GameObject.Find ("ShakingStationCamera").GetComponent<Camera> ();
//	}

	void CameraControls()
	{
		// pan controls
		if (Input.touchCount == 1)
		{
			// check if finger has moved across screen
			if (Input.GetTouch (0).phase == TouchPhase.Moved)
			{
				// Get movement of the finger since last frame
				Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

				// Move worldCam across XY plane
				worldCam.transform.Translate (-touchDeltaPosition.x * panSpeed * Time.deltaTime, -touchDeltaPosition.y * panSpeed* Time.deltaTime, 0);
				worldCam.transform.position = new Vector3 (
					Mathf.Clamp (transform.position.x, minX, maxX),
					Mathf.Clamp(transform.position.y, 8.5f, 8.5f),
					Mathf.Clamp (transform.position.z, minZ, maxZ));
			}
		}

		// zoom controls
		if (Input.touchCount == 2)
		{
			Touch touchZero = Input.GetTouch (0);
			Touch touchOne = Input.GetTouch (1);

			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

			if (worldCam.orthographic)
			{
				worldCam.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;
				worldCam.orthographicSize = Mathf.Max (GetComponent<Camera> ().orthographicSize, 0.1f);
			}
			else
			{
				worldCam.fieldOfView += deltaMagnitudeDiff * perspectiveZoonSpeed;
				worldCam.fieldOfView = Mathf.Clamp (GetComponent<Camera> ().fieldOfView, 25f, 60f);
			}
		}


		if (Input.GetTouch (0).phase == TouchPhase.Began)
		{
			ray = worldCam.ScreenPointToRay (Input.GetTouch (0).position);

			Debug.DrawRay (ray.origin, ray.direction * 30, Color.cyan);

			if(Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				// check to see if interactive station touched
				if (hit.transform.tag == "MenuStation")
				{
					print("Tapped Menu Station");
					ShowMenuStationCam ();
				}

				if (hit.transform.tag == "CuttingStation")
				{
					print("Tapped Cutting Station");
					ShowCuttingStationCam ();
				}

				if (hit.transform.tag == "BlendingStation")
				{
					print("Tapped Blending Station");
					ShowBlendingStationCam ();
				}

				if (hit.transform.tag == "ShakingStation")
				{
					print("Tapped Shaking Station");
					ShowShakingStationCam ();
				}

				// check to see if customer request bubble touched
				if (hit.transform.tag == "Request")
				{
					print ("Tapped request bubble");

					if (hit.transform.GetComponentInParent<S_CustomerGeneration> ().myRequest == "Lemon Twist" && GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenLemonTwist > 0)
					{
						// disable lemon twist on bar
						GameObject.Find("ShakingStationCamera").GetComponent<S_ShakingStationControls>().lemonTwist.SetActive(false);
						// minus 1 from inventory
						GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenLemonTwist--;
						// give customer happy face
						GameObject.Find("Customer(Clone)").GetComponent<S_CustomerGeneration>().HappyCustomer();

							// if happy face, leave

					}

					if (hit.transform.GetComponentInParent<S_CustomerGeneration> ().myRequest == "Orange Crush" && GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenOrangeCrush > 0)
					{
						// disable lemon twist on bar
						GameObject.Find("ShakingStationCamera").GetComponent<S_ShakingStationControls>().orangeCrush.SetActive(false);
						// minus 1 from inventory
						GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenOrangeCrush--;
						// give customer happy face
						GameObject.Find("Customer(Clone)").GetComponent<S_CustomerGeneration>().HappyCustomer();

						// if happy face, leave

					}

					if (hit.transform.GetComponentInParent<S_CustomerGeneration> ().myRequest == "Citrus Burst" && GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenCitrusBurst > 0)
					{
						// disable lemon twist on bar
						GameObject.Find("ShakingStationCamera").GetComponent<S_ShakingStationControls>().citrusBurst.SetActive(false);
						// minus 1 from inventory
						GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenCitrusBurst--;
						// give customer happy face
						GameObject.Find("Customer(Clone)").GetComponent<S_CustomerGeneration>().HappyCustomer();

						// if happy face, leave

					}

					if (hit.transform.GetComponentInParent<S_CustomerGeneration> ().myRequest == "Banana Banter" && GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenBananaBanter > 0)
					{
						// disable lemon twist on bar
						GameObject.Find("ShakingStationCamera").GetComponent<S_ShakingStationControls>().bananaBanter.SetActive(false);
						// minus 1 from inventory
						GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenBananaBanter--;
						// give customer happy face
						GameObject.Find("Customer(Clone)").GetComponent<S_CustomerGeneration>().HappyCustomer();

						// if happy face, leave

					}

					if (hit.transform.GetComponentInParent<S_CustomerGeneration> ().myRequest == "Berry Bliss" && GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenBerryBliss > 0)
					{
						// disable lemon twist on bar
						GameObject.Find("ShakingStationCamera").GetComponent<S_ShakingStationControls>().berryBliss.SetActive(false);
						// minus 1 from inventory
						GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenBerryBliss--;
						// give customer happy face
						GameObject.Find("Customer(Clone)").GetComponent<S_CustomerGeneration>().HappyCustomer();

						// if happy face, leave

					}

					if (hit.transform.GetComponentInParent<S_CustomerGeneration> ().myRequest == "Abomination" && GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenAbomination > 0)
					{
						// disable lemon twist on bar
						GameObject.Find("ShakingStationCamera").GetComponent<S_ShakingStationControls>().abomination.SetActive(false);
						// minus 1 from inventory
						GameObject.Find("GameManager").GetComponent<S_InventoryManager>().currentShakenAbomination--;
						// give customer happy face
						GameObject.Find("Customer(Clone)").GetComponent<S_CustomerGeneration>().HappyCustomer();

						// if happy face, leave

					}
				}

			}
		}


	}

	public void ShowWorldCam()
	{
		worldCam.enabled = true;
		canMoveWorldCam = true;
		menuStationCam.enabled = false;
		menuStationCanvas.enabled = false;
		cuttingStationCam.enabled = false;
		cuttingStationCanvas.enabled = false;
		cuttingStationControls.GetComponent<S_CuttingStationControls> ().enabled = false;
		cuttingStationCollider.GetComponent<BoxCollider> ().enabled = true;
		blendingStationCam.enabled = false;
		blendingStationCanvas.enabled = false;
		blendingStationControls.GetComponent<S_BlendingStationControls> ().enabled = false;
		blendingStationCollider.GetComponent<BoxCollider> ().enabled = true;
		shakingStationCam.enabled = false;
		shakingStaionCanvas.enabled = false;
		shakingStationControls.GetComponent<S_ShakingStationControls> ().enabled = false;
		shakingStationCollider.GetComponent<BoxCollider> ().enabled = true;
	}

	void ShowMenuStationCam()
	{
		worldCam.enabled = false;
		canMoveWorldCam = false;
		menuStationCam.enabled = true;
		menuStationCanvas.enabled = true;
		cuttingStationCam.enabled = false;
		cuttingStationCanvas.enabled = false;
		cuttingStationControls.GetComponent<S_CuttingStationControls> ().enabled = false;
		cuttingStationCollider.GetComponent<BoxCollider> ().enabled = false;
		blendingStationCam.enabled = false;
		blendingStationCanvas.enabled = false;
		blendingStationControls.GetComponent<S_BlendingStationControls> ().enabled = false;
		blendingStationCollider.GetComponent<BoxCollider> ().enabled = false;
		shakingStationCam.enabled = false;
		shakingStaionCanvas.enabled = false;
		shakingStationControls.GetComponent<S_ShakingStationControls> ().enabled = false;
		shakingStationCollider.GetComponent<BoxCollider> ().enabled = false;
	}

	void ShowCuttingStationCam()
	{
		worldCam.enabled = false;
		canMoveWorldCam = false;
		menuStationCam.enabled = false;
		menuStationCanvas.enabled = false;
		cuttingStationCam.enabled = true;
		cuttingStationCanvas.enabled = true;
		cuttingStationControls.GetComponent<S_CuttingStationControls> ().enabled = true;
		cuttingStationCollider.GetComponent<BoxCollider> ().enabled = false;
		blendingStationCam.enabled = false;
		blendingStationCanvas.enabled = false;
		blendingStationControls.GetComponent<S_BlendingStationControls> ().enabled = false;
		blendingStationCollider.GetComponent<BoxCollider> ().enabled = false;
		shakingStationCam.enabled = false;
		shakingStaionCanvas.enabled = false;
		shakingStationControls.GetComponent<S_ShakingStationControls> ().enabled = false;
		shakingStationCollider.GetComponent<BoxCollider> ().enabled = false;
	}

	void ShowBlendingStationCam()
	{
		worldCam.enabled = false;
		canMoveWorldCam = false;
		menuStationCam.enabled = false;
		menuStationCanvas.enabled = false;
		cuttingStationCam.enabled = false;
		cuttingStationCanvas.enabled = false;
		cuttingStationControls.GetComponent<S_CuttingStationControls> ().enabled = false;
		cuttingStationCollider.GetComponent<BoxCollider> ().enabled = false;
		blendingStationCam.enabled = true;
		blendingStationCanvas.enabled = true;
		blendingStationControls.GetComponent<S_BlendingStationControls> ().enabled = true;
		blendingStationCollider.GetComponent<BoxCollider> ().enabled = false;
		shakingStationCam.enabled = false;
		shakingStaionCanvas.enabled = false;
		shakingStationControls.GetComponent<S_ShakingStationControls> ().enabled = false;
		shakingStationCollider.GetComponent<BoxCollider> ().enabled = false;
	}

	void ShowShakingStationCam()
	{
		worldCam.enabled = false;
		canMoveWorldCam = false;
		menuStationCam.enabled = false;
		menuStationCanvas.enabled = false;
		cuttingStationCam.enabled = false;
		cuttingStationCanvas.enabled = false;
		cuttingStationControls.GetComponent<S_CuttingStationControls> ().enabled = false;
		cuttingStationCollider.GetComponent<BoxCollider> ().enabled = false;
		blendingStationCam.enabled = false;
		blendingStationCanvas.enabled = false;
		blendingStationControls.GetComponent<S_BlendingStationControls> ().enabled = false;
		blendingStationCollider.GetComponent<BoxCollider> ().enabled = false;
		shakingStationCam.enabled = true;
		shakingStaionCanvas.enabled = true;
		shakingStationControls.GetComponent<S_ShakingStationControls> ().enabled = true;
		shakingStationCollider.GetComponent<BoxCollider> ().enabled = false;
	}
}
