using UnityEngine;

public class Gravity : MonoBehaviour {

    private World world;
    private BallworldObject ballworldObject;
    private float strength = 0.1f;

    void Start()
    {
        ballworldObject = GetComponent<BallworldObject>();
        world = FindObjectOfType<World>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(ballworldObject.transform.position, world.transform.position) > world.radius)
        {
            ballworldObject.transform.position -= ballworldObject.transform.forward * strength;
            strength *= 1.03f;
        }

        if (Vector3.Distance(ballworldObject.transform.position, world.transform.position) < world.radius)
        {
            ballworldObject.transform.position = ballworldObject.transform.forward * world.radius;
            strength = 0.1f;
        }
    }
}
