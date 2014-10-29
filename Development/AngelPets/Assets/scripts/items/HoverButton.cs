using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HoverButton : PlayerInteractive {

	public List<Instruction> instructions = new List<Instruction>();
	public bool mustBeStationary = true;

	public override void PlayerEnter (Player player)
	{

	}

	public override void PlayerStay (Player player)
	{
		float vel = player.GetComponent<Velocity> ().Vel;
		if (mustBeStationary) {
			if(vel <= 0.001f){
				RunInstructions ();
			}
		} else {
			RunInstructions ();
		}
	}

	public void RunInstructions(){
		for (int i = 0; i < this.instructions.Count; i++) {
			instructions[i].Run();
		}
	}
}
