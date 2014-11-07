using UnityEngine;
using System.Collections;

public abstract class Code : MonoBehaviour
{
	/// <summary>
	/// Execute some instruction. Returns true if the instruction has finished. 
	/// </summary>
	public abstract bool Execute();
}

