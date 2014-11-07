using UnityEngine;
using System.Collections;

public class OrthographicsCameraManager : MonoBehaviour
{
		public float width = 16;
		public float height = 9;

		// Use this for initialization
		void Start ()
		{				
				
		}

		void Update ()
		{
				Camera camera = GetComponent<Camera> ();
				camera.orthographic = true;
				float windowaspect = (float)Screen.width / (float)Screen.height;
				float target = (width / height) * 10;
				camera.orthographicSize = target / windowaspect;
		}
	
}