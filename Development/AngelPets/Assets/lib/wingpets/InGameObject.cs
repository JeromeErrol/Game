using UnityEngine;
using System.Collections;

public class InGameObject : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
				gameObject.GetOrCreateComponent<Speed> ().relativeTo = Game.Instance.gameObject.GetOrCreateComponent<Speed> ();
		}
}

