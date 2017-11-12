using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CameraController : MonoBehaviour
{
	// zoom speeds
	public float perspectiveZoonSpeed = 0.5f;
	public float orthoZoomSpeed = 0.5f;

	private float minX, maxX, minZ, maxZ;
	private Vector3 myPosition;
	public float panSpeed = 0.5f;

	// Use this for initialization
	void Start ()
	{
		minX = -6f;
		maxX = 5.1f;
		minZ = -12.3f;
		maxZ = 1.4f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		myPosition = transform.position;

		// check if there are touches
		if (Input.touchCount > 0)
		{
			// pan controls
			if (Input.touchCount == 1)
			{

				if (Input.GetTouch (0).phase == TouchPhase.Moved)
				{
					// Get movement of the finger since last frame
					Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

//					if (myPosition.x < maxX || myPosition.x > minX || myPosition.z < maxZ || myPosition.z > minZ)
//					{
						// Move object across XY plane
						transform.Translate (-touchDeltaPosition.x * panSpeed, -touchDeltaPosition.y * panSpeed, 0);
					transform.position = new Vector3 (
						Mathf.Clamp (transform.position.x, minX, maxX),
						Mathf.Clamp(transform.position.y, 11, 11),
						Mathf.Clamp (transform.position.z, minZ, maxZ));
//					}


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

				if (GetComponent<Camera> ().orthographic)
				{
					Camera.main.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;
					Camera.main.orthographicSize = Mathf.Max (GetComponent<Camera> ().orthographicSize, 0.1f);
				}
				else
				{
					Camera.main.fieldOfView += deltaMagnitudeDiff * perspectiveZoonSpeed;
					Camera.main.fieldOfView = Mathf.Clamp (GetComponent<Camera> ().fieldOfView, 25f, 60f);
				}
			}
		}
	}
}
