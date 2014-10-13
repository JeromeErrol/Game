using UnityEngine;
using System.Collections;


namespace GameUtil2D
{	
	public static class GOUtil2D{
		public static float GetRadions(GameObject gameObject){
			return Mathf.Deg2Rad * gameObject.transform.eulerAngles.z;
		}
	}
}