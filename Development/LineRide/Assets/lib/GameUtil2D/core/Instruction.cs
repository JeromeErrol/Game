using UnityEngine;
using System.Collections;

public abstract class Instruction : MonoBehaviour
{	
	public abstract void Begin();
	public abstract void Run();
	public abstract bool IsFinished();
}

