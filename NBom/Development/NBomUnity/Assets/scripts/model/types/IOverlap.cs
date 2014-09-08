using UnityEngine;
using System.Collections;
using System;

public class IOverlap : MonoBehaviour
{	
	public virtual void OverlapTriggered(RocketShip rocketShip){
		throw new NotImplementedException ();
	}

	public virtual void ExitTriggered(RocketShip gameObject){
		throw new NotImplementedException ();
	}
}

