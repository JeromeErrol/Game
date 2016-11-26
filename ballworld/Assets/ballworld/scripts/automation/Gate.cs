using UnityEngine;

public class Gate : BallworldObject {

    public Transform openTransform;
    public Transform closedTransform;
    public string state = "closed";
    public float speed = 0.1f;
    public int timeOpen = 1000;
    public int time = 0;

    public void open()
    {
        state = "opening";
    }
	
	// Update is called once per frame
	void Update () {
	    if(state == "opening")
        {
            if(Vector3.Distance(transform.position, openTransform.position) > speed)
            {
                moveTowards(openTransform.position, speed); 
            }else
            {
                state = "open";
            }
        }

        if (state == "closing")
        {
            if (Vector3.Distance(transform.position, closedTransform.position) <= speed)
            {
                state = "closed";
            }
            else
            {
                moveTowards(closedTransform.position, speed);
            }
        }

        if( state == "open")
        {
            if(time++ > timeOpen)
            {
                time = 0;
                state = "closing";
            }
        }
    }
}
