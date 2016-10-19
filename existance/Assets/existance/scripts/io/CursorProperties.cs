using UnityEngine;

public class CursorProperties : MonoBehaviour {

	public CursorLockMode cursorLockMode;
    public bool cursorVisible = true;   

    // Update is called once per frame
    void Update () {
        Cursor.lockState = cursorLockMode;
        // Hide cursor when locking
        Cursor.visible = cursorVisible;
    }
}
