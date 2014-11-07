using UnityEngine;
using System.Collections;

public class ForLoop : Code
{
		public int frameCount;
		public Code code;
		private int index = 0;

		public override bool Execute ()
		{
				if (index <= frameCount) {
						code.Execute ();
						return false;
				} else {
						return true;
				}
		}
}

