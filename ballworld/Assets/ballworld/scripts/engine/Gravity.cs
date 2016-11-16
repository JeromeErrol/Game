using UnityEngine;

public class Gravity : MonoBehaviour {

    public World world;

    private BallworldObject ballworldObject;
    public float strength;

    void Start()
    {
        ballworldObject = GetComponent<BallworldObject>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(ballworldObject.transform.position, world.transform.position) > world.radius)
        {
            ballworldObject.transform.position -= ballworldObject.transform.forward * strength;
        }

        if (Vector3.Distance(ballworldObject.transform.position, world.transform.position) < world.radius)
        {
            ballworldObject.transform.position = ballworldObject.transform.forward * world.radius;
        }
    }
}
