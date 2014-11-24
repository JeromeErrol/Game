using UnityEngine;
using System.Collections;

public class Ring : MonoBehaviour {

	public int level;
	

	void Start () {
	
	}

	public float Experience{
		get{
			return level * 100;
		}
	}
	
	void Update () {
	
	}
}
