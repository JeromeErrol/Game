using UnityEngine;
using System.Collections;

public class IRingCollector : MonoBehaviour
{
	public int pointsCollected;

	void OnTriggerEnter2D (Collider2D collider2D)
	{		
		Ring ring = collider.gameObject.GetComponent<Ring>();
		if (ring) {
			pointsCollected += ring.value;
			GameObject.Destroy(ring.gameObject);
		}
	}
}

