using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Function : Code
{
		public List<Code> codes = new List<Code> ();
		private int _currentIndex = 0;
		public bool loop;

		void Start ()
		{
				codes.RemoveAll (item => item == null);		
		}

		public override bool Execute ()
		{
				while (CurrentInstruction != null) {
						if (CurrentInstruction.enabled == true) {
								// If the current instruction hasn't finished running stay here.
								if (CurrentInstruction.Execute () == false) {
										return false;
								} 
						}
						NextInstruction ();
				}
				return true;

				
		}
	
		public Code CurrentInstruction {
				get {
						if (_currentIndex < codes.Count) {
								return codes [_currentIndex];
						} else {
								return null;
						}					
				}
		}

		public void NextInstruction ()
		{		
				_currentIndex++;
				if (loop) {
						_currentIndex = _currentIndex % codes.Count;	
				}
		}
}

