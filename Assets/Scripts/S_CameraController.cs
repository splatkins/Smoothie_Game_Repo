using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CameraController : MonoBehaviour
{
	// zoom speeds
	public float perspectiveZoonSpeed = 0.5f;
	public float orthoZoomSpeed = 0.5f;

	private float minX, maxX, minZ, maxZ;
	//private Vector3 myPosition;
	public float panSpeed = 0.2f;

	Ray ray;
	RaycastHit hit;

	public Camera worldCam;
	public Camera cuttingStationCam;
	public Camera blendingStationCam;
	public Canvas cuttingStationCanvas;
	public Canvas blendingStationCanvas;
	bool canMoveWorldCam;


	// Use this for initialization
	void Start ()
	{
		ShowWorldCam ();
	//	cuttingStationCam = GameObject.FindWithTag ("CuttingStationCamera");

		minX = -6f;
		maxX = 5.1f;
		minZ = -12.3f;
		maxZ = 1.4f;
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
	}

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
				worldCam.transform.Translate (-touchDeltaPosition.x * panSpeed, -touchDeltaPosition.y * panSpeed, 0);
				worldCam.transform.position = new Vector3 (
					Mathf.Clamp (transform.position.x, minX, maxX),
					Mathf.Clamp(transform.position.y, 11, 11),
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

		// check to see if interactive object touched
		if (Input.GetTouch (0).phase == TouchPhase.Began)
		{
			ray = worldCam.ScreenPointToRay (Input.GetTouch (0).position);

			Debug.DrawRay (ray.origin, ray.direction * 30, Color.cyan);

			if(Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				if (hit.transform.tag == "CuttingStation")
				{
					print("Hit Cutting Station");
					ShowCuttingStationCam ();
				}

				if (hit.transform.tag == "BlendingStation")
				{
					print("Hit Blending Station");
					ShowBlendingStationCam ();
				}
			}
		}
	}

	public void ShowWorldCam()
	{
		worldCam.enabled = true;
		canMoveWorldCam = true;
		cuttingStationCam.enabled = false;
		cuttingStationCanvas.enabled = false;
		blendingStationCam.enabled = false;
		blendingStationCanvas.enabled = false;
	}

	void ShowCuttingStationCam()
	{
		worldCam.enabled = false;
		canMoveWorldCam = false;
		cuttingStationCam.enabled = true;
		cuttingStationCanvas.enabled = true;
		blendingStationCam.enabled = false;
		blendingStationCanvas.enabled = false;
	}

	void ShowBlendingStationCam()
	{
		worldCam.enabled = false;
		canMoveWorldCam = false;
		cuttingStationCam.enabled = false;
		cuttingStationCanvas.enabled = false;
		blendingStationCam.enabled = true;
		blendingStationCanvas.enabled = true;
	}
}
