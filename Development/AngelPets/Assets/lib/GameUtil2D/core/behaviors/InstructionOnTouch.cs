using UnityEngine;
using System.Collections;

public class InstructionOnTouch : UserInteractive
{
	public Instruction instruction;
		
	public override void Pressed()
	{
		instruction.Run ();
	}
}

