using UnityEngine;
using System.Collections;

public class RainDrop : MonoBehaviour
{
		void Start ()
		{
			gameObject.AddComponent<Rigidbody2D> ();
		}

		void Update ()
		{
			if (transform.position.y < -10) {
				GameObject.Destroy(gameObject);
			}
		}
}

