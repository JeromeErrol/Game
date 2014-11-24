using UnityEngine;
using System.Collections;

public class LoadScene : Instruction
{
	public string scene;

	public override void Begin ()
	{

	}

	public override bool IsFinished ()
	{
		return false;
	}

	public override void Run ()
	{
		Application.LoadLevel (scene);
	}
}

