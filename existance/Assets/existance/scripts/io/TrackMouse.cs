using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.existance.scripts.io
{
    /***
     *  Makes an object rotate towards the mouse
     **/
    class TrackMouse : MonoBehaviour
    {
        void Update()
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Quaternion rot = Quaternion.LookRotation(mousePosition - transform.position, transform.TransformDirection(Vector3.back));
            transform.rotation = new Quaternion(0, 0, rot.z, rot.w);
        }
    }
}
