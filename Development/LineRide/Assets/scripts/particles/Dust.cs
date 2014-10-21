using UnityEngine;
using System.Collections;

public class Dust : MonoBehaviour
{
		public float LifeSpan = 300;
		private float age = 0;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
			age++;
			if (age > LifeSpan) {
				GameObject.Destroy(gameObject);
			}

		//	gameObject.renderer.material.set
		}
}

