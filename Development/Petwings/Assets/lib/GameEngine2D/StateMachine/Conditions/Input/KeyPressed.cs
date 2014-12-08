using UnityEngine;
using System.Collections;

public class KeyPressed : TransitionCondition
{
		public KeyCode key;
		public bool held;

		public override bool Met {
				get {
						if (held) {
								return Input.GetKey (key);
						} else {
								return Input.GetKeyDown (key);
						}
				}
		}
}

