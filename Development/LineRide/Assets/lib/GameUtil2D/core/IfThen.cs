using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IfThen : MonoBehaviour
{
		public List<Condition> conditions = new List<Condition> ();
		public List<Instruction> instructions = new List<Instruction> ();

		void Update ()
		{
				if (AllConditionsMet) {
					RunInstructions();
				}
		}

		private bool AllConditionsMet {
				get {
						for (int i = 0; i < this.conditions.Count; i++) {
								if (conditions [i].IsMet() == false) {
										return false;
								}
						}
						return true;
				}
		}

		private void RunInstructions(){
				for (int i = 0; i < this.instructions.Count; i++) {
					Instruction instruction = instructions[i];
					instruction.Run();
				}
		}
}

