using UnityEngine;
using System.Collections;

public abstract class Value2D : MonoBehaviour
{
	public GameObject target;
		
	public GameObject Target{
		get{
			if(target == null){
				target = gameObject;
			}
			return target;
		}
	}

	public abstract float Value{ get; set;}
}

