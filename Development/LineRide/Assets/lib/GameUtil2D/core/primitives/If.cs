using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class If : Code
{
		public List<Condition> conditions = new List<Condition> ();
		public List<Code> instructions = new List<Code> ();
		
		void Start ()
		{
				conditions.RemoveAll (item => item == null);
				instructions.RemoveAll (item => item == null);	
		}

		public override void Execute ()
		{
				if (AllConditionsMet) {
						RunInstructions ();
				}
		}
	
		private bool AllConditionsMet {
				get {
						foreach (Condition condition in conditions) {
								if (condition.IsMet () == false) {
										return false;
								}
						}
						return true;
				}
		}
	
		private void RunInstructions ()
		{
				foreach (Code instruction in instructions) {
						instruction.Execute ();
				}
		}
}

