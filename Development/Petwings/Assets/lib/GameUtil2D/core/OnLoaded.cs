using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class OnLoaded : MonoBehaviour
{
		private static List<Action> callbacks = new List<Action> ();

		public static void Add (Action action)
		{
				callbacks.Add (action);

				OnLoaded loader = GameObject.FindObjectOfType<OnLoaded> ();
				if (loader == null) {
						new GameObject ("OnLoad").AddComponent<OnLoaded> ();
				}
		}
	
		void Update ()
		{
				foreach (Action action in OnLoaded.callbacks) {
						action ();
				}
				OnLoaded.callbacks.Clear ();
				Destroy (this);
		}
}

