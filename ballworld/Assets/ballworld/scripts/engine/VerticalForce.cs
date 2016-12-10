using UnityEngine;

public class VerticalForce : MonoBehaviour {

    private BallworldObject ballworldObject;
    public float amount;
    
	void Start () {
        ballworldObject = GetComponent<BallworldObject>();
	}
	
	void Update () {
        ballworldObject.transform.position += ballworldObject.transform.forward * amount;
        amount *= 0.95f;
        if(amount < 0.1)
        {
            Destroy(this);
        }
    }
}
