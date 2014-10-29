using UnityEngine;
using System.Collections;

public abstract class Instruction : MonoBehaviour
{	
	public bool runAutomatically = false;

	void Start(){
		Clean ();
		if (runAutomatically) {
			Begin();
		}
	}

	void Update ()
	{

		if (runAutomatically && !IsFinished()) {
			Run ();	
		}
	}

	public virtual void Clean(){

	}


	public abstract void Begin ();
	public abstract void Run ();
	public abstract bool IsFinished ();
}

