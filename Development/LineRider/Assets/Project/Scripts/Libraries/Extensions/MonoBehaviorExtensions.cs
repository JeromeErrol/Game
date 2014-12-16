using UnityEngine;
using System.Collections;

public static class MonoBehaviorExtensions
{

		public static bool CurrentAnimationStateNameIs (this MonoBehaviour monoBehavior, string name)
		{
				return monoBehavior.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName (name);
		}
}

