using UnityEngine;
using System.Collections;

public class SoundEffect : MonoBehaviour {

	public AudioClip clip;


	void Play(){
		audio.PlayOneShot (clip);
	}
}
