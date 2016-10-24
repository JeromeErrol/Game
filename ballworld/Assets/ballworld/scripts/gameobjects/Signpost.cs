using UnityEngine;
using System.Collections;

public class Signpost : MonoBehaviour {

    public GameObject front;
    public GameObject top;    

    public void viewFront()
    {
        front.SetActive(true);
        top.SetActive(false);
    }

    public void viewTop()
    {
        front.SetActive(false);
        top.SetActive(true);
    }
}
