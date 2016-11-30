using UnityEngine;

public class ArrowPool : MonoBehaviour {

    public static ArrowPool instance;

    void Start () {
        instance = this;
	}
}
