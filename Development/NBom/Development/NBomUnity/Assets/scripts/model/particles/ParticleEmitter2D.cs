using UnityEngine;
using System.Collections;
using GameUtil2D;

public class ParticleEmitter2D:MonoBehaviour
{	
	public int framesPerShot = 8;
	private int frameUntilShot = 0;
	public float power = 10.0f;
	public float spread = 0.5f;
	public Color color;
	public Vector2 scale;
	public float alphaChange;
	public float scaleChange;

	void Update(){
		if (frameUntilShot > 0) {			
			frameUntilShot--;
		}
	}

	public AbstractParticle Shoot(float radions){
		if (frameUntilShot <= 0) {
			radions = Random.Range(radions - spread, radions + spread);
			frameUntilShot = framesPerShot;

			GameObject go = StageUtil2D.AddGameObject (Resources2D.Circle01);
			go.AddComponent<Rigidbody2D>();
			go.name = "Particle";
			go.rigidbody2D.gravityScale = 0;
			go.rigidbody2D.velocity = PhysicsUtil2D.GetVelocity (radions, power); ;
			go.transform.position = transform.position;
			go.renderer.material.color = color;
			go.transform.localScale = scale;

			AbstractParticle particle = go.AddComponent<AbstractParticle> ();
			particle.alphaChange = alphaChange;
			particle.scaleChange = scaleChange;
		}
		return null;
	}
}

