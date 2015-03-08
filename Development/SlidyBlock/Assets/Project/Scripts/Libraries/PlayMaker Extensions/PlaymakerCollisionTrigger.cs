using UnityEngine;
using System.Collections;

public class PlaymakerCollisionTrigger : MonoBehaviour
{
		public PlayMakerFSM fsm;
		public string eventName;
		public GameObject target;

		void Awake ()
		{
				if (fsm == null) {
						fsm = GetComponent<PlayMakerFSM> ();
				}
		}

		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				if (collider2D.gameObject == target) {
						fsm.SendEvent (eventName);
				}
		}
}

