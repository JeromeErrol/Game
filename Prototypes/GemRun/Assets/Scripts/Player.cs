using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
		public int level;
		public static Player instance;
		public KeyCode downKey = KeyCode.DownArrow;
		public KeyCode upKey = KeyCode.UpArrow;
		public float ySpeed = 1.3882f;
		public float experience;

		void Start ()
		{
				Player.instance = this;
				gameObject.GetOrCreateComponent<PlayerCollision> ();
		}
	
		void Update ()
		{
				if (Input.GetKeyDown (downKey)) {
						GoDown ();
				}
				if (Input.GetKeyDown (upKey)) {
						GoUp ();
				}
		}

		public void GoDown ()
		{
				Vector3 pos = transform.position;
				pos.y -= ySpeed;
				transform.position = pos;
		}

		public void GoUp ()
		{				
				Vector3 pos = transform.position;
				pos.y += ySpeed;
				transform.position = pos;
		}

		public void CollectRing (Ring ring)
		{
				ring.gameObject.Destroy ();
		}

		public void Die ()
		{
				Scene.instance.RestartScene ();
		}
}

