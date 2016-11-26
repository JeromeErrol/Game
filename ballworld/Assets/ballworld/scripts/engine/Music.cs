using UnityEngine;

public class Music : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip audioClip;

	void Start () {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
	}
}
