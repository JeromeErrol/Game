using UnityEngine;
using System.Collections;

namespace GameUtil2D
{
		public class CustomSnap : MonoBehaviour
		{
				public float snapSize;
	
				public void Snap ()
				{						
						float x = MathUtil2D.RoundOff (transform.position.x, snapSize);
						float y = MathUtil2D.RoundOff (transform.position.y, snapSize);
						transform.position = new Vector3 (x, y, transform.position.z);	
				}
		}
}
