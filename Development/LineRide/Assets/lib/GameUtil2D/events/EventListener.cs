using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventListener : MonoBehaviour
{
		public List<EventAction> eventActions = new List<EventAction>();

		public void Fire(){
			foreach (EventAction eventAction in eventActions) {
				eventAction.Fire();
			}
		}
}

