using UnityEngine;
using System.Collections;

public class IfElse : Code
{
		public Code condition;
		public Code ifInstruction;
		public Code elseInstruction;

		public override bool Execute ()
		{
				if (condition.Execute ()) {
						return ifInstruction.Execute ();
				} else {
						return elseInstruction.Execute ();
				}
		}
}

