using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IfThen : MonoBehaviour
{
		public List<Condition> conditions = new List<Condition> ();
		public List<Instruction> instructions = new List<Instruction> ();

		void Start(){
			conditions.RemoveAll(item => item == null);
			instructions.RemoveAll(item => item == null);			
		}

		void Update ()
		{
				if (AllConditionsMet) {
					RunInstructions();
				}
		}		

		private bool AllConditionsMet {
				get {
 						foreach (Condition condition in conditions) {
								if (condition.IsMet() == false) {
										return false;
								}
						}
						return true;
				}
		}

		private void RunInstructions(){
				foreach (Instruction instruction in instructions) {
					instruction.Run();
				}
		}
}

