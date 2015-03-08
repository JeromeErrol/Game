using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
		private List<Player> players;
		public KeyCode RightKey = KeyCode.D;
		public KeyCode LeftKey = KeyCode.A;

		void Start ()
		{
				players = new List<Player>(GameObject.FindObjectsOfType<Player> ());
		}
    
		void FixedUpdate ()
		{
				if (Input.GetKey (LeftKey)) {
						foreach (Player player in players) {
								player.GoLeft ();
						}
				} else if (Input.GetKey (RightKey)) {
						foreach (Player player in players) {
								player.GoRight ();
						}
				} else {
						foreach (Player player in players) {
								player.Stand ();
						}
				}
		}
}
