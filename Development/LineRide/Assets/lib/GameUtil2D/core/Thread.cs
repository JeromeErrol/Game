using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Thread : Instruction
{
		public List<Instruction> instructions;
		private bool run = false;

		void Start ()
		{
			
		}

		public override void Begin ()
		{
			run = false;
		}

		public override void Clean ()
		{

		}

		public override bool IsFinished ()
		{
				return run;
		}

		public override void Run ()
		{
			GameObject thread = new GameObject ("Thread");
			Instructions instruction = thread.AddComponent<Instructions> ();
			instruction.instructions = instructions;	
			instruction.runAutomatically = true;
			run = true;
		}
}

