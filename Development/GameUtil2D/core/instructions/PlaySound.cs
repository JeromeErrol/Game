using UnityEngine;
using System.Collections;

public class PlaySound : Instruction
{
	public AudioClip sound;
	private bool playing;

	public override void Begin ()
	{
		playing = false;
	}

	public override bool IsFinished ()
	{
		return playing;
	}

	public override void Run ()
	{
		audio.PlayOneShot (sound);
		playing = true;
	}
}

