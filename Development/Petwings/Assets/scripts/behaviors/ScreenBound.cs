using UnityEngine;
using System.Collections;

public class ScreenBound : MonoBehaviour
{	
		void Update ()
		{
				Vector3 pos = gameObject.transform.position;
				pos.x = gameObject.transform.position.x % 28.55f;
				pos.y = gameObject.transform.position.y % 8.7f;
				gameObject.transform.position = pos;
		}
}

