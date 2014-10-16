using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PressButton : PlayerInteractive {
	
	public List<Instruction> instructions = new List<Instruction>();
	
	public override void PlayerEnter (Player player)
	{
		for (int i = 0; i < this.instructions.Count; i++) {
			instructions[i].Run();
		}
	}
}
