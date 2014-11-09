using UnityEngine;
using System.Collections;

public class LevelInstructions : MonoBehaviour
{
		void Start ()
		{
				gameObject.name = "Level Instructions";
				new GameObject().AddComponent<Die> ().transform.parent = transform;
		}
}

