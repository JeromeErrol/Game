using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class For : Instruction
{
		public int numberOfFrames;
		private int currentFrame;
		public List<Instruction> instructions = new List<Instruction>();

		public override void Begin ()
		{
			currentFrame = 0;
		}

		public override void Clean ()
		{
			instructions.RemoveAll(item => item == null);		
		}

		public override void Run ()
		{
				currentFrame++;
				for (int i = 0; i < instructions.Count; i++) {
					instructions[i].Run();
				}
		}

		public override bool IsFinished ()
		{
			return (currentFrame >= numberOfFrames);
		}
}

