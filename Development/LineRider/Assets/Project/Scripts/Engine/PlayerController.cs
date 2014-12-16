using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
		public KeyCode RightKey = KeyCode.D;
		public KeyCode LeftKey = KeyCode.A;
    
		void FixedUpdate ()
		{
				if (Input.GetKey (LeftKey)) {
						Player.instance.GoLeft ();
				} else if (Input.GetKey (RightKey)) {
						Player.instance.GoRight ();
				} else {
						Player.instance.Stand ();
				}
		}
}
