using UnityEngine;
using System.Collections;

public class SetX : Setter
{
		public Transform x;

		public override void Set ()
		{
				Target.GetOrCreateComponent<Movement> ().position.x = x.position.x;
		}
}

