using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class NodeList : MonoBehaviour
	{
		public List<GameObject> nodes;			

		void Start(){
			Transform[] ts = gameObject.GetComponentsInChildren<Transform>();
			foreach (Transform child in transform)
			{
				nodes.Add(child.gameObject);
			}
		}
	}
}

