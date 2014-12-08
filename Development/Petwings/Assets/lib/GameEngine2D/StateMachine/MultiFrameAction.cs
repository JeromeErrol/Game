using UnityEngine;
using System.Collections;

public abstract class MultiFrameAction : MonoBehaviour
{
	public abstract bool HasFinished{ get; }
	public abstract void Start();
	public abstract void Run();
	public abstract void Interrupted();
}

