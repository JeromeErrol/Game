using UnityEngine;
using System.Collections;

public class Tween : Instruction
{
	public float initialSpeed;
	public float finalSpeed;
	public float time;
	private float currentFrame;

	void Start(){
		currentFrame = 0;
	}

	public float Acceleration{
		get{
			return (finalSpeed - initialSpeed) / time;
		}
	}	

	public float GetValueAtFrame(float frame){
		return initialSpeed + (Acceleration * frame);
	}	

	public override void Begin ()
	{
		currentFrame = 0;
	}

	public override bool IsFinished ()
	{
		return currentFrame >= time;
	}

	public override void Run ()
	{
		currentFrame++;
	}
}

