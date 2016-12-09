using UnityEngine;
using System.Collections;

public class IO : MonoBehaviour {    

    public static float MouseScroll
    {
        get
        {
            return Input.GetAxis("Mouse ScrollWheel");
        }
    }

    public static float MouseX
    {
        get
        {
            return Input.GetAxis("Mouse X");
        }
    }

    public static float MouseY
    {
        get
        {
            return Input.GetAxis("Mouse Y");
        }
    }
}
