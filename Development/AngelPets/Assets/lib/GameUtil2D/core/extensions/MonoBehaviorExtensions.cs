using UnityEngine;
using System.Collections;

public static class MonoBehaviorExtensions
{

	public static Vector3 Position (this MonoBehaviour monoBehavior)
	{
		return monoBehavior.gameObject.transform.position;
	}

	public static Vector3 Position (this MonoBehaviour monoBehavior, Vector3 position)
	{
		monoBehavior.gameObject.transform.position = position;
		return position;
	}

}

