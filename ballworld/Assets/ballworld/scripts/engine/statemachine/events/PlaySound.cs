using UnityEngine;

public class PlaySound : GameEvent {
       
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    public override void happen()
    {
        audioSource.Play();
    }
}
