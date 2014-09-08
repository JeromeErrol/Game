using UnityEngine;
using System.Collections;

public class Level:MonoBehaviour
{
	public RocketShip rocketShip;
	public string levelName;
	public float gridSize = 15.396f;

	public static Level instance;

	void Start(){
		instance = this;
	}
}

