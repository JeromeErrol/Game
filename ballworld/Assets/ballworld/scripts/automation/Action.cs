using UnityEngine;

public class Action : MonoBehaviour {

    public BallworldObject ballworldObject;
    
	void Start () {
        if (ballworldObject != null) {
            ballworldObject = GetComponent<BallworldObject>();
        }
	}

    public virtual void perform()
    {

    }

    public virtual bool isFinished()
    {
        return true;
    }
}
