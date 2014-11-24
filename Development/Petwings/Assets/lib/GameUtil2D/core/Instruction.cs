using UnityEngine;
using System.Collections;

public abstract class Instruction : MonoBehaviour
{	
		public bool runAutomatically = false;

		void Start ()
		{
				Clean ();
				if (runAutomatically) {
						Begin ();
				}
		}

		void Update ()
		{
				if (runAutomatically && !IsFinished ()) {
						Run ();	
				}
		}

		public virtual void Clean ()
		{

		}

		public abstract void Begin ();

		public abstract void Run ();

		public abstract bool IsFinished ();

		public static void TurnOffInstructions ()
		{
				Instruction[] instructions = GameObject.FindObjectsOfType<Instruction> ();
				for (int i = 0; i < instructions.Length; i++) {
						instructions [i].enabled = false;
				}
		}

		public static void TurnOnInstructions ()
		{
				Instruction[] instructions = GameObject.FindObjectsOfType<Instruction> ();
				for (int i = 0; i < instructions.Length; i++) {
						instructions [i].enabled = true;
				}
		}
}

