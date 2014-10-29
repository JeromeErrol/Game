using UnityEngine;
using System.Collections;

public class Lifespan : MonoBehaviour
{
		public int lifeSpan;
		private int age;

		void Start ()
		{
				age = 0;
		}
	
		void Update ()
		{
				if (age >= lifeSpan) {
						gameObject.Destroy ();
				} else {
						age++;
				}
		}
}

