using System.Collections;
using UnityEngine;
using GameUtil2D;

public class CameraController:MonoBehaviour
{
		public KeyCode zoomOutKey = KeyCode.Z;
		public KeyCode zoomInKey = KeyCode.X;

		public CameraController ()
		{

		}

		void Update ()
		{	
				if (Input.GetKeyDown (zoomOutKey)) {
						ZoomOut ();					
				}

				if (Input.GetKeyDown (zoomInKey)) {
						ZoomIn ();					
				}
		}

		void ZoomOut ()
		{
				Zoom (-1f);
		}

		void ZoomIn ()
		{
				Zoom (1f);
		}

		void Zoom (float amount)
		{
				Vector3 cameraPosition = Camera.main.transform.position;
				cameraPosition.Set (cameraPosition.x, cameraPosition.y, cameraPosition.z + amount);
				Camera.main.transform.position = cameraPosition;
		}
}
