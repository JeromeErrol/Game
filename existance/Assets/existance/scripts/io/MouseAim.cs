using UnityEngine;

namespace Assets.existance.scripts.io
{
    public class MouseAim : MonoBehaviour
    {
        public float sensitivityX = 4;

        void Start()
        {
            Cursor.lockState = CursorLockMode.Confined;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (Cursor.lockState == CursorLockMode.Confined)
                {
                    Cursor.lockState = CursorLockMode.None;
                }
                else
                {
                    Cursor.lockState = CursorLockMode.Confined;
                }
            }
        }

        void LateUpdate()
        {
            float x = Input.GetAxis("Mouse X");
            Vector3 eulerAngles = transform.rotation.eulerAngles;
            eulerAngles.z -= x * sensitivityX;
            Quaternion rotation = transform.rotation;
            rotation.eulerAngles = eulerAngles;
            transform.rotation = rotation;
        }
    }
}
