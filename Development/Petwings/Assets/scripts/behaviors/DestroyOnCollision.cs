using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D collider2D)
	{				
		GameObject.Destroy(collider2D.gameObject);
	}
}

