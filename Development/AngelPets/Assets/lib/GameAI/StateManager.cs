using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour
{
		public TargetState targetState;

		void Update ()
		{
				float difference = targetState.rotation - gameObject.transform.eulerAngles.z;
				float updateValue = difference / 600f;
				//gameObject.ro
		}
}

