using UnityEngine;
using System.Collections;

public class SetY : Setter
{
		public Transform y;

		public override void Set ()
		{
				Target.GetOrCreateComponent<Movement> ().position.y = y.position.y;
		}
}

