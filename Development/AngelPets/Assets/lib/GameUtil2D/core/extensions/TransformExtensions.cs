using UnityEngine;
using System.Collections;

public static class TransformExtensions
{
	public static void MoveTowards(this Transform transform, GameObject targetGameObject, float distance){
		transform.position = Vector3.MoveTowards (transform.position, targetGameObject.transform.position, distance * transform.gameObject.GetOrCreateComponent<Speed>().RelativeSpeed);
	}

	public static void MoveTowards(this Transform transform, Transform targetTransform, float distance){
		transform.position = Vector3.MoveTowards (transform.position, targetTransform.position, distance * transform.gameObject.GetOrCreateComponent<Speed>().RelativeSpeed);
	}

	public static void MoveTowards(this Transform transform, Vector3 position, float distance){
		transform.position = Vector3.MoveTowards (transform.position, position, distance * transform.gameObject.GetOrCreateComponent<Speed>().RelativeSpeed);
	}

}

