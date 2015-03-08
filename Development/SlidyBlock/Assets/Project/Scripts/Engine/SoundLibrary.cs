using UnityEngine;
using System.Collections;

public class SoundLibrary : MonoBehaviour
{
		public static SoundLibrary instance;
		public AudioClip death;
		public AudioClip levelComplete;
		public AudioClip keyCollected;
		private AudioSource audioSource;

		public void Awake ()
		{
				SoundLibrary.instance = this;
				this.audioSource = gameObject.AddComponent<AudioSource> ();
		}

		public static void PlayDeath ()
		{
				instance.audioSource.PlayOneShot (instance.death);
		}

		public static void PlayLevelComplete ()
		{
				instance.audioSource.PlayOneShot (instance.levelComplete);
		}

		public static void PlayKeyCollected ()
		{
				instance.audioSource.PlayOneShot (instance.keyCollected);
		}

		public void Start ()
		{
				switch (EventHistory.LastState) {
				case GameEvent.Died:
						PlayDeath ();
						return;
				case GameEvent.LevelCompleted:
						PlayLevelComplete ();
						return;
				default:
						return;
				}
		}
}

