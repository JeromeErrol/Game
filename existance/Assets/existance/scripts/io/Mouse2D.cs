using UnityEngine;

namespace Assets.existance.scripts.io
{
    public class Mouse2D : MonoBehaviour
    {
        public static Vector2 CameraPosition
        {
            get
            {
                return Camera.main.ScreenToWorldPoint(Input.mousePosition); 
            }
        }

        public static Vector3 CameraPosition3
        {
            get
            {
                return Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }

        
    }
}
