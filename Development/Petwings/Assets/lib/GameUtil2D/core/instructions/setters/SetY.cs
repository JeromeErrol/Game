using UnityEngine;
using System.Collections;

public class SetY : Setter
{
		public Transform y;

		public override void Set ()
		{
			Target.transform.gameObject.Y(y.position.y);
		}
}

