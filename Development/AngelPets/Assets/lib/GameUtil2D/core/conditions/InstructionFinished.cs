using UnityEngine;
using System.Collections;

public class InstructionFinished : Condition
{
	public Instruction instruction;

	public override bool IsMet ()
	{
		return instruction.IsFinished ();
	}
}

