using UnityEngine;
using System.Collections;

public class SetActive : Setter
{
		public bool value = true;

		public override void Set ()
		{
				Target.SetActive (value);
		}
}

