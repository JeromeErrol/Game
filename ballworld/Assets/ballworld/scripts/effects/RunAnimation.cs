using UnityEngine;
using System.Collections;

public class RunAnimation : MonoBehaviour {
        
    public int frames = 50;
    public float changerPerFrame = 0.01f;
    private int currentFrame = 1;
    public bool running = false;
	
	void Update () {
        if (running)
        {
            if (currentFrame > frames)
            {
                currentFrame = 0;
                changerPerFrame = -changerPerFrame;
            }
            transform.localScale += new Vector3(changerPerFrame, changerPerFrame, 0);
            currentFrame++;
        }
	}
}
