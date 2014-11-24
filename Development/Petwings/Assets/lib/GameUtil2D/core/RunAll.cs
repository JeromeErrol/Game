using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RunAll : Instruction
{
		public List<Instruction> instructions = new List<Instruction> ();

		void Start ()
		{
				instructions.RemoveAll (item => item == null);		
		}

		public override void Run ()
		{
				for (int i = 0; i < instructions.Count; i++) {
						if (instructions [i].IsFinished () == false) {
								instructions [i].Run ();
						}
				}
		}

		public override bool IsFinished ()
		{
				for (int i = 0; i < instructions.Count; i++) {
						if (instructions [i].IsFinished () == false) {
								return false;
						}
				}
				return true;
		}

		public override void Begin ()
		{
				for (int i = 0; i < instructions.Count; i++) {
						instructions [i].Begin ();
				}
		}

		public override void Clean ()
		{
				instructions.RemoveAll (item => item == null);		
				for (int i = 0; i < instructions.Count; i++) {
						instructions [i].Clean ();
				}
		}
}

