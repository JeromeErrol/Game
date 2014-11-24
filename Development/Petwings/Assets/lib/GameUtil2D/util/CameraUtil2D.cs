using UnityEngine;
using System.Collections;

namespace GameUtil2D
{
		public static class CameraUtil2D
		{
				public static void SetZ (float z)
				{
						Vector3 cameraPosition = Camera.main.transform.position;
						cameraPosition.Set (cameraPosition.x, cameraPosition.y, z);
						Camera.main.transform.position = cameraPosition;
				}

		}
}


