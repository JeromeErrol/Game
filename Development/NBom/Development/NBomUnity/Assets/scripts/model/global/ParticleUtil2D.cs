using UnityEngine;
using System.Collections;

public class ParticleUtil2D 
{
	private static ParticleEmitter2D _streamEmitter;

	private static ParticleEmitter2D streamEmmiter{
		get{
			if(_streamEmitter == null){
				_streamEmitter = Level.instance.gameObject.AddComponent<ParticleEmitter2D>();
				_streamEmitter.color = Color.black;
				_streamEmitter.framesPerShot = 1;
				_streamEmitter.power = 0f;
				_streamEmitter.spread = 0f;	
				_streamEmitter.scale = new Vector2(0.1f, 0.1f);
				_streamEmitter.alphaChange = -0.05f;
			}
			return _streamEmitter;
		}
	}

	public static void EmitDust(float radions, Vector3 position){
		streamEmmiter.transform.position = position;
		AbstractParticle dust = streamEmmiter.Shoot (radions);
	}
}

