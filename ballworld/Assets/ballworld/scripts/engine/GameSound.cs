using UnityEngine;

public class GameSound : MonoBehaviour {

    private AudioSource swordSlashAudioSource;
    public AudioClip swordSlash;
    
	void Start () {
        swordSlashAudioSource = gameObject.AddComponent<AudioSource>();
        swordSlashAudioSource.clip = swordSlash;
	}

    public void playSwordSlash()
    {
        swordSlashAudioSource.Play();
    }
}
