using UnityEngine;
using System.Collections;
using System;

public class Die : MonoBehaviour
{
		private Instructions instructions;
		private Pause pause1;
		private RestartLevel restartLevel;
		private Destroy destroy;
		private DelegateInstruction playSound;
		private ParticleGenerator particleGenerator;

		void Awake ()
		{
				gameObject.name = "DIE()";
				instructions = gameObject.AddComponent<Instructions> ();
				destroy = gameObject.AddComponent<Destroy> ();
				destroy.target = Player.instance.gameObject;
				pause1 = gameObject.AddComponent<Pause> ();
				Pause pause2 = gameObject.AddComponent<Pause> ();
				pause2.duration = 60;
				playSound = gameObject.AddComponent<DelegateInstruction> ();
				playSound.action = SoundLibrary.PlayDeath;
				particleGenerator = gameObject.AddComponent<ParticleGenerator> ();
				particleGenerator.enabled = false;
				particleGenerator.particleLifeTime = 200;
				particleGenerator.alpha = 1;
				particleGenerator.alphaChange = -0.02f;
				particleGenerator.velocityRange = new Vector2 (0.1f, 0.1f);
				particleGenerator.scale = new Vector3 (0.2f, 0.2f, 0);
				particleGenerator.sprite = SpriteLibrary.Instance.circle;
				ActivateBehavior activateParticleGen = gameObject.AddComponent<ActivateBehavior> ();
				activateParticleGen.behavior = particleGenerator;
				DeactivateBehavior deactivateParticleGen = gameObject.AddComponent<DeactivateBehavior> ();
				deactivateParticleGen.behavior = particleGenerator;
				DelegateInstruction setPos = gameObject.AddComponent<DelegateInstruction> ();
				setPos.action = SetParticlePositionToPlayer;
				pause1.duration = 7;
				restartLevel = gameObject.AddComponent<RestartLevel> ();
				instructions.instructions.Add (setPos);
				instructions.instructions.Add (destroy);
				instructions.instructions.Add (activateParticleGen);
				instructions.instructions.Add (playSound);
				instructions.instructions.Add (pause1);
				instructions.instructions.Add (deactivateParticleGen);
				instructions.instructions.Add (pause2);
				instructions.instructions.Add (restartLevel);
		}

		void SetParticlePositionToPlayer ()
		{
				gameObject.transform.position = Player.instance.transform.position;
		}


		
}

