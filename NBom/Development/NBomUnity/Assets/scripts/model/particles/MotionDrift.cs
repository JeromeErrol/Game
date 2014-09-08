using UnityEngine;
using System.Collections;
using GameUtil2D;

public class MotionDrift : MonoBehaviour {

	private GameObject particle;

	// Use this for initialization
	void Start () {
		Sprite sprite = Asset2DUtil.LoadTexture ("particles/driftlines/driftlines01.png");
		particle = StageUtil.AddGameObject (sprite);
	}
	
	// Update is called once per frame
	void Update () {
		//if (gameObject.rigidbody2D.velocity.magnitude > 0) {
			particle.transform.position = gameObject.transform.position;
			particle.transform.rotation = gameObject.transform.rotation;
		//}
	}
}
