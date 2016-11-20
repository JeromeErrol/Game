using UnityEngine;

public class UnitController : MonoBehaviour {

    public Unit unit;
    public Weapon sword;
    public Weapon bow;

    public KeyCode jump = KeyCode.Space;
    public KeyCode runKey = KeyCode.W;
    public KeyCode backKey = KeyCode.S;
    public KeyCode strafeLeftKey = KeyCode.A;
    public KeyCode strafeRightKey = KeyCode.D;
    public float jumpSpeed = 1f;
    public float sensitivityX = 4;    

    void Update () {

        if (Input.GetKey(runKey))
        {
            unit.unitState = UnitState.RUNNING_FORWARD;

            if (Input.GetKey(strafeLeftKey))
            {
                unit.unitState = UnitState.RUNNING_FORWARD_LEFT;
            }else 
            if (Input.GetKey(strafeRightKey))
            {
                unit.unitState = UnitState.RUNNING_FORWARD_RIGHT;
            }
        }
        else
        if (Input.GetKey(backKey))
        {
            unit.unitState = UnitState.RUNNING_BACKWARD;

            if (Input.GetKey(strafeLeftKey))
            {
                unit.unitState = UnitState.RUNNING_BACKWARDS_LEFT;
            }
            else
            if (Input.GetKey(strafeRightKey))
            {
                unit.unitState = UnitState.RUNNING_BACKWARDS_RIGHT;
            }
        }
        else
        if (Input.GetKey(strafeLeftKey))
        {
            unit.unitState = UnitState.STRAFING_LEFT;
        }
        else
        if (Input.GetKey(strafeRightKey))
        {
            unit.unitState = UnitState.STRAFING_RIGHT;
        }
        else
        {
            unit.unitState = UnitState.IDLE;
        }

        if (Input.GetMouseButtonDown(0))
        {
            sword.gameObject.SetActive(true);
            if (bow.enabled)
            {
                bow.gameObject.SetActive(false);
            }
        }

        if (Input.GetMouseButton(0))
        {
            sword.draw();
        }

        if (Input.GetMouseButtonUp(0))
        {
            sword.release();
        }
        if (Input.GetMouseButton(1))
        {
            bow.draw();
        }
        if (Input.GetMouseButtonDown(1))
        {
            bow.gameObject.SetActive(true);
            if (sword.enabled)
            {
                sword.gameObject.SetActive(false);
            }
        }
        if (Input.GetMouseButtonUp(1))
        {
            bow.release();
        }

        if (Input.GetKey(jump))
        {
            unit.transform.position += unit.transform.forward * jumpSpeed;
        }
        Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel");
        Camera.main.fieldOfView -= (Input.GetAxis("Mouse ScrollWheel") * 10);
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
