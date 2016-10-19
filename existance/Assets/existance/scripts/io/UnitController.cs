using Assets.existance.scripts.io;
using UnityEngine;

public class UnitController : MonoBehaviour {

    public Unit unit;
    public KeyCode runKey = KeyCode.UpArrow;
    public KeyCode backKey = KeyCode.S;
    public KeyCode strafeLeftKey = KeyCode.LeftArrow;
    public KeyCode strafeRightKey = KeyCode.RightArrow;

    void Update () {
	    if(Input.GetKey(runKey))
        {
            unit.run();
        }
        if (Input.GetKey(backKey))
        {
            unit.runBackwards();
        }
        if (Input.GetKey(strafeLeftKey))
        {
            unit.strafeLeft();
        }
        if (Input.GetKey(strafeRightKey))
        {
            unit.strafeRight();
        }
        // unit.lookAt(Mouse2D.CameraPosition);
    }
}
