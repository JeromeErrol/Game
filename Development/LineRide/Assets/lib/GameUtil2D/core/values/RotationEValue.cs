using UnityEngine;
using System.Collections;

public class RotationQValue : Value2D
{
	public override float Value {
		get {
			return Target.transform.eulerAngles.z;
		}
		set {
			Vector3 q = Target.transform.eulerAngles;
			q.z = value;
			Target.transform.eulerAngles = q;
		}
	}		
}

