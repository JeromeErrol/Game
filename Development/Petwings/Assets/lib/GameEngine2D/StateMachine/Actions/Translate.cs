using UnityEngine;
using System.Collections;

namespace StateFramework.Actions
{
		public class Translate : SingleFrameAction
		{
				public Vector2 translation;
				public Transform target;

				public override void Run ()
				{
						Vector3 pos = target.position;
						pos.x += translation.x;
						pos.y += translation.y;
						target.position += pos;
				}
		}
}

