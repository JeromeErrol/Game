using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class SimpleCondition : Condition
{
	public List<Instruction> instructions = new List<Instruction>();
	
	void Update(){
		if (IsMet ()) {
			RunInstructions();
		}
	}

	private void RunInstructions(){
		for (int i = 0; i < this.instructions.Count; i++) {
			this.instructions[i].Run();
		}
	}
}

