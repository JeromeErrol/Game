using UnityEngine;
using System.Collections;

public class AbstractParticle : MonoBehaviour
{		
		public float alphaChange = 0.05f;
		public float scaleChange = 0.015f;
	
		void Update ()
		{
				Color color = renderer.material.color;
				color.a += alphaChange;
				renderer.material.color = color;		
				if (color.a <= alphaChange) {
						GameObject.Destroy (gameObject);
				}	
				transform.localScale = new Vector3 (transform.localScale.x + scaleChange, transform.localScale.y + scaleChange); 	
		}
}

