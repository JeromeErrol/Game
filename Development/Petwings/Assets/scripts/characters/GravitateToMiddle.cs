using UnityEngine;
using System.Collections;

public class GravitateToMiddle : MonoBehaviour
{
		public float middleY;
		public float speed;

		// Use this for initialization
		void Start ()
		{
			
		}
	
		// Update is called once per frame
		void Update ()
		{
				float y = transform.position.y;
				if (y < middleY) {
						y += speed;
				}

				if (y > middleY) {
						y -= speed;
				}

				gameObject.Y (y);
		}
}

