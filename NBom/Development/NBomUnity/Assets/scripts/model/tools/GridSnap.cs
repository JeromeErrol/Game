using UnityEngine;
using System.Collections;

public class GridSnap : MonoBehaviour
{
		public float width;
		public float height;

		public const float Standard = 15.396f;
		public const float StandardFifth = 3.0792f;
		
		// Use this for initialization
		void Start ()
		{
				float diffX = transform.position.x % (width);
				float diffY = transform.position.y % height;
				float x;
				float y;
			
				if (width / 2f > diffX) {
						x = transform.position.x - (transform.position.x % width);
				} else {
						x = transform.position.x + (width - diffX);
				}	

				if (height / 2f > diffY) {
						y = transform.position.y - (transform.position.y % height);
				} else {
						y = transform.position.y + (height - diffY);
				}	
				transform.position = new Vector3 (x, y, transform.position.z);	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}

