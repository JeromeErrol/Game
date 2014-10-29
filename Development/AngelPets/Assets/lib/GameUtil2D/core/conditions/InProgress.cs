using UnityEngine;
using System.Collections;

public class InProgress : Condition
{
	public Instruction instruction;
	
	public override bool IsMet ()
	{
		return instruction.IsFinished () == false;
	}
}

