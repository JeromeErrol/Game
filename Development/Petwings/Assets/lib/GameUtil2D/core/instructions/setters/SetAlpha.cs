using UnityEngine;
using System.Collections;

public class SetAlpha : Setter
{
		public float alpha;
	
		public override void Set ()
		{
				Target.SetAlpha (alpha);
		}
	
}
