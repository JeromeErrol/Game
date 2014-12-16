using UnityEngine;
using System.Collections;

public class Rules : MonoBehaviour
{	
		public float targetDistance;
	
		void Update ()
		{
				if (Player.Position.x > targetDistance) {
						GameFSM.LoadNextLevel ();
				}
		}
}

