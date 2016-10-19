using UnityEngine;
using System.Collections;

public class UnitController : MonoBehaviour {

    public Unit unit;

    public KeyCode runKey = KeyCode.W;
    public KeyCode backKey = KeyCode.S;
    public KeyCode strafeLeftKey = KeyCode.A;
    public KeyCode strafeRightKey = KeyCode.D;    

    public float sensitivityX = 4;

    void Update () {

        if (Input.GetKey(runKey))
        {
            unit.runForward();
        }
        if (Input.GetKey(backKey))
        {
            unit.runBackward();
        }
        if (Input.GetKey(strafeLeftKey))
        {
            unit.strafeLeft();
        }
        if (Input.GetKey(strafeRightKey))
        {
            unit.strafeRight();
        }

        unit.boost = Input.GetMouseButton(1);
    }

    void LateUpdate()
    {
        float x = Input.GetAxis("Mouse X");
        Vector3 eulerAngles = unit.transform.rotation.eulerAngles;
        eulerAngles.z += x * sensitivityX;
        Quaternion rotation = transform.rotation;
        rotation.eulerAngles = eulerAngles;
        unit.transform.rotation = rotation;
    }
}
