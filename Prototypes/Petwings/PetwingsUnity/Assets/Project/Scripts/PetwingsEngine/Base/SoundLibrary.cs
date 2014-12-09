using UnityEngine;
using System.Collections;
using BaseEngine.Extensions;

public class SoundLibrary : MonoBehaviour
{
		public AudioClip pickupCoin;
		private static SoundLibrary instance;
		private AudioSource audioSource;

		void Awake ()
		{
				instance = this;
				this.GetOrCreateComponent<AudioListener> ();
				audioSource = this.GetOrCreateComponent<AudioSource> ();
		}

		public static void PlayCoin ()
		{
				instance.audioSource.PlayOneShot (instance.pickupCoin);
		}

		public static void Play (AudioClip clip)
		{
				instance.audioSource.PlayOneShot (clip);
		}
}

