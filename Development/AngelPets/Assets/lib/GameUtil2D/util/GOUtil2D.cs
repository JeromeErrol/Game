using UnityEngine;
using System.Collections;


namespace GameUtil2D
{	
	public static class GOUtil2D{
		public static float GetRadions(GameObject gameObject){
			return Mathf.Deg2Rad * gameObject.transform.eulerAngles.z;
		}

		public static void AddRotation(GameObject gameobjet, float amount){
			Vector3 angle = gameobjet.transform.eulerAngles;
			angle.z += amount;
			gameobjet.transform.eulerAngles = angle;

		}

		
		public static void RemoveAllComponentsOfType<T> () where T : Component
		{
			T[] components = GameObject.FindObjectsOfType<T> ();
			foreach (T audioListener in components) {
				MonoBehaviour.Destroy(audioListener);
			}
		}
	}
}