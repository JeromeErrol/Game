using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Function : Code
{
	public List<Code> instructions = new List<Code> ();

	public override void Execute ()
	{
		instructions.RemoveAll(item => item == null);
		foreach (Code instruction in instructions) {
			instruction.Execute();
		}
	}		
}

