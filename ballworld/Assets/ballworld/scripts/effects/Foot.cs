using UnityEngine;
using System.Collections;

public class Foot : MonoBehaviour {

    public float amount = 1f;

    public int totalFrames = 20;
    public int currentFrame = 0;

    void Update()
    {
        if(currentFrame++ > totalFrames)
        {
            currentFrame = 0;
            amount = -amount;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * amount);
    }

}
