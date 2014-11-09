using UnityEngine;
using System.Collections;
using GameUtil2D;
using System.Collections.Generic;
using System;

public class SoundLibrary : MonoBehaviour
{
		public AudioClip levelCompleted;
		public AudioClip death;
		public AudioClip gameOver;
		public AudioClip newGame;
		public static SoundLibrary Instance;
	
		void Awake ()
		{
				GOUtil2D.RemoveAllComponentsOfType<AudioListener> ();
				gameObject.GetOrCreateComponent<AudioSource> ();
				gameObject.GetOrCreateComponent<AudioListener> ();
				SoundLibrary.Instance = this;
		}

		public static void PlayLevelCompleted ()
		{
				Instance.audio.PlayOneShot (Instance.levelCompleted);
		}

		public static void PlayDeath ()
		{
				Instance.audio.PlayOneShot (Instance.death);
		}

		public static void PlayGameOver ()
		{
				Instance.audio.PlayOneShot (Instance.gameOver);
		}

		public static void PlayNewGame ()
		{
				Instance.audio.PlayOneShot (Instance.newGame);
		}
}

