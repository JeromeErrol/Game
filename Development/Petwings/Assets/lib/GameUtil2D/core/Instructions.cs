using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Instructions : Instruction
{
		public List<Instruction> instructions = new List<Instruction> ();
		private int _currentIndex = 0;
		public bool loop;
		public bool runIfGamePaused = false;

		public Instruction CurrentInstruction {
				get {
						if (_currentIndex < instructions.Count) {
								return instructions [_currentIndex];
						} else {
								return null;
						}					
				}
		}

		public override void Clean ()
		{
				instructions.RemoveAll (item => item == null);			
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
				Clean ();
				for (int i = 0; i < instructions.Count; i++) {
						instructions [i].Begin ();				
				}
		}

		public override void Run ()
		{
				if (!Game.Instance.Paused || runIfGamePaused) {
				
						if (CurrentInstruction == null || CurrentInstruction.IsFinished () || CurrentInstruction.enabled == false) {
								NextInstruction ();
						} else {
								CurrentInstruction.Run ();
						}

				}
				
		}
	
		public override bool IsFinished ()
		{
				return _currentIndex >= instructions.Count;
		}
}

