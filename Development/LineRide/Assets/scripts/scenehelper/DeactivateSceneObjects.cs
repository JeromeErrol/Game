using UnityEngine;
using System.Collections;

public class DeactivateSceneObjects : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
			Object[] objects = GameObject.FindObjectsOfType (typeof(PolygonCollider2D));

			for(int i = 0 ; i < objects.Length; i++){
				PolygonCollider2D poly = objects[i] as PolygonCollider2D;

			//	if(poly.gameObject.X() > 
			}
		}
}

