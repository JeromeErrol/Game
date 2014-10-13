using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Level : MonoBehaviour {

	public static Level instance;
	private int nextSpawn = 0;
	public int timePerSpawn = 100;

	void Start () {
		Sprites.LoadSprites ();	
		new Hierarchy ();
		instance = this;
	}

	void Update () {
		instance = this;

		nextSpawn--;
		if (nextSpawn <= 0) {
			nextSpawn = timePerSpawn;
			SpawnPiece();
		}
	}

	bool a = true;
	void SpawnPiece(){
		if (a) {
			Spawn (Sprites.banana_x1);
				} else {
			Spawn (Sprites.cherry_x1);
				}
		a = !a;

	}

	void Spawn(Sprite sprite){
		GameObject gameObject = new GameObject ();
		SpriteRenderer renderer = gameObject.AddComponent<SpriteRenderer> ();
		gameObject.AddComponent<Item> ();
		renderer.sprite = sprite;
		gameObject.transform.position = GameObject.Find("SpawnPosition").transform.position;
	}
}
