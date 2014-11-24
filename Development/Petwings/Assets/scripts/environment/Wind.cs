using UnityEngine;
using System.Collections;

public class Wind : MonoBehaviour
{
		public float strength;


		void Update ()
		{
			GameObject player = GameObject.Find ("Player");	
			player.GetComponent<Velocity> ().AddAcceleration (strength);
		}
}

