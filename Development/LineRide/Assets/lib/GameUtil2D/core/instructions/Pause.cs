using UnityEngine;
using System.Collections;

public class Pause : Instruction
{
	public int duration;
	private int _duration;

	public override void Run ()
	{
		_duration--;
	}

	public override bool IsFinished ()
	{
		return _duration < 0;
	}

	public override void Begin ()
	{
		_duration = duration;
	}
}

