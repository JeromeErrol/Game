using UnityEngine;
using System.Collections;

public class ForwardMovement : MonoBehaviour
{
		public static ForwardMovement instance;
		PlayMakerFSM fsm;

		void Start ()
		{
				instance = this;
				fsm = GetComponent<PlayMakerFSM> ();
		}

		public float Speed {
				get {
						return fsm.FsmVariables.FindFsmFloat ("speed").Value;
				}set {
						fsm.FsmVariables.FindFsmFloat ("speed").Value = value;
				}
		}
}

