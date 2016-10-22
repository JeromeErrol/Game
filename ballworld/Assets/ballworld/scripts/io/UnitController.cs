using UnityEngine;
using System.Collections;

public class UnitController : MonoBehaviour {

    private Unit unit;

    public KeyCode runKey = KeyCode.W;
    public KeyCode backKey = KeyCode.S;
    public KeyCode strafeLeftKey = KeyCode.A;
    public KeyCode strafeRightKey = KeyCode.D;    

    public float sensitivityX = 4;

    void Start()
    {
        this.unit = GetComponent<Unit>();
    }

    void Update () {
        unit.standStill();
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

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Gun>().fire();
        }

        unit.boost = Input.GetMouseButton(1);
        
        Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel");
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
