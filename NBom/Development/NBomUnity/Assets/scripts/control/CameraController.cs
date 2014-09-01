using System.Collections;
using UnityEngine;
using GameUtil2D;

public class CameraController:MonoBehaviour
{
		public KeyCode zoomOutKey = KeyCode.Z;
		public KeyCode zoomInKey = KeyCode.X;
		public KeyCode moveUpKey = KeyCode.W;
		public KeyCode moveDownKey = KeyCode.S;
		public KeyCode moveLeftKey = KeyCode.A;
		public KeyCode moveRightKey = KeyCode.D;
		public float camMoveSpeed = 0.001f;

		public CameraController ()
		{

		}

		void Update ()
		{	
				if (Input.GetKey (zoomOutKey)) {
						ZoomOut ();					
				}

				if (Input.GetKey (zoomInKey)) {
						ZoomIn ();					
				}

				if (Input.GetKey (moveUpKey)) {
						Vector3 camPos = Camera.main.transform.position;
						camPos.y += camMoveSpeed;
						Camera.main.transform.position = camPos;
				}

				if (Input.GetKey (moveDownKey)) {
						Vector3 camPos = Camera.main.transform.position;
						camPos.y -= camMoveSpeed;
						Camera.main.transform.position = camPos;
				}

				if (Input.GetKey (moveLeftKey)) {
						Vector3 camPos = Camera.main.transform.position;
						camPos.x -= camMoveSpeed;
						Camera.main.transform.position = camPos;
				}

				if (Input.GetKey (moveRightKey)) {
						Vector3 camPos = Camera.main.transform.position;
						camPos.x += camMoveSpeed;
						Camera.main.transform.position = camPos;
				}
		}

		void ZoomOut ()
		{
				Zoom (-0.1f);
		}

		void ZoomIn ()
		{
				Zoom (0.1f);
		}

		void Zoom (float amount)
		{
				Vector3 cameraPosition = Camera.main.transform.position;
				cameraPosition.Set (cameraPosition.x, cameraPosition.y, cameraPosition.z + amount);
				Camera.main.transform.position = cameraPosition;
		}
}
