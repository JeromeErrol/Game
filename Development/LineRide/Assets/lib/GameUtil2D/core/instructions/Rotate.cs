using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Rotate : TargetedInstruction
{
	public float amount;
	public float framesToFinished;
	private float _currentFrame;

	public float RotationPerFrame{
		get{
			return amount / framesToFinished;
		}
	}

	public override bool IsFinished ()
	{
		return _currentFrame >= framesToFinished;
	}

	public override void Run ()
	{
		_currentFrame++;
		Target.transform.Rotate (new Vector3(0, 0, RotationPerFrame));
	}

	public override void Begin ()
	{
		_currentFrame = 0;
	}
}

