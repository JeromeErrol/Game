using UnityEngine;
using System.Collections;

public class Boost : MonoBehaviour
{
	public float power;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

	void OnTriggerEnter2D (Collider2D collider2D)
	{		
			if (collider2D.gameObject.GetComponent<Player> ()) {
				Player player = collider2D.gameObject.GetComponent<Player> ();
				player.rigidbody2D.AddForce(new Vector2(this.power, 0));
				GameObject.Destroy(gameObject);
			}		
	}
}

