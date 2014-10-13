using UnityEngine;
using System.Collections;
using GameUtil2D;

public class TestSuite : MonoBehaviour
{
		void Start ()
		{
				
		}

		void Run ()
		{
				float angle = 0;
		
				for (float distance = 0; distance < 1000; distance += 10) {
						Vector2 position = Spiral.ToVector2 (distance, angle);
						GameObject circle = DebugUtil.AddCircle (position);
						angle += 0.05f;
						circle.transform.localScale = new Vector3 (2, 2, 1);
				}
		}
}

