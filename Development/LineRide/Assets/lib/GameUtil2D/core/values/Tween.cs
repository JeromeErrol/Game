using UnityEngine;
using System.Collections;

public class Tween : MonoBehaviour
{
	public float initialSpeed;
	public float finalSpeed;
	public float time;

	void Update(){

	}


	public float Acceleration{
		get{
			return (finalSpeed - initialSpeed) / time;
		}
	}		
}

