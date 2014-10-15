using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Instructions : Instruction
{
		public List<Instruction> instructions = new List<Instruction> ();
		private int _currentIndex = 0;
		public bool loop;
		public bool runAutomatically = true;

		void Update ()
		{
				if (runAutomatically) {
						Run ();	
				}
		}

		public Instruction CurrentInstruction {
				get {
						if (_currentIndex < instructions.Count) {
								return instructions [_currentIndex];
						} else {
								return null;
						}					
				}
		}

		public void NextInstruction ()
		{		
				_currentIndex++;
				if (loop) {
						_currentIndex = _currentIndex % instructions.Count;	
				}
				if (CurrentInstruction != null) {
						CurrentInstruction.Begin ();
				}
		}

		public override void Begin ()
		{
				_currentIndex = 0;
				for (int i = 0; i < instructions.Count; i++) {
						instructions [i].Begin ();				
				}
		}

		public override void Run ()
		{
				if (CurrentInstruction.IsFinished ()) {
						NextInstruction ();
				} else {
						CurrentInstruction.Run ();
				}
		}
	
		public override bool IsFinished ()
		{
				return _currentIndex >= instructions.Count;
		}
}

