using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class State : MonoBehaviour
{
		public List<MultiFrameAction> multiFrameActions = new List<MultiFrameAction> ();
		public List<SingleFrameAction> singleFrameActions = new List<SingleFrameAction> ();
		public List<StateTransition> transitions = new List<StateTransition> ();
}

