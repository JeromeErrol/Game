using UnityEngine;

public class Spawn : MonoBehaviour {

    public Unit unit;

    public int framesBetweenSpawn = 100;
    public int nextSpawn = 0;
	
	// Update is called once per frame
	void Update () {
	    if(nextSpawn++ >= framesBetweenSpawn)
        {
            nextSpawn = 0;
            GameObject.Instantiate(unit, transform.position, transform.rotation, transform);
        }
	}
}
