using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Player : MonoBehaviour
{
		public KeyCode accelerateKey = KeyCode.RightArrow;
		public KeyCode breakKey = KeyCode.LeftArrow;
		public float acceleration;
		public static int currentLevel = 0;
		public bool activated = false;
		public int heldDownFor = 0;


		

		void FixedUpdate ()
		{
				ReadKeyboardInput ();
				ReadScreenInput ();

				if (gameObject.Left () < GameScreen.Left) {
						gameObject.Left (GameScreen.Left);
				}

				if (transform.position.x > GameScreen.Right) {
						Level.instance.NextLevel ();
				}
		}

		void EjectMist ()
		{
				float velocity = GetComponent<Velocity> ().Vel;

				if (velocity > 0) {

						float x = transform.position.x;
						float y = renderer.bounds.min.y;


						GameObject particle = StageUtil2D.AddGameObject (Res.Pixel, new Vector3 (x, y));
						particle.AddComponent<Dust> ();
						particle.transform.localScale = new Vector3 (10, 10);


				}
		}

		void ReadScreenInput ()
		{
				for (var i = 0; i < Input.touchCount; ++i) {
						Touch touch = Input.GetTouch (i);

						if (activated == false) {

								if (touch.phase == TouchPhase.Began) {
										activated = true;
								}
						}						

						if (activated) {
								if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved) {
										if (touch.position.x > (Screen.width / 2)) {
												Accelerate ();
										} else {
												Reverse ();
										}
								}
						} 
				}
		}

		void ReadKeyboardInput ()
		{
				if (Input.GetKeyDown (accelerateKey) || Input.GetKeyDown (breakKey)) {
						activated = true;
				}
			
				if (Input.GetKey (accelerateKey)) {
						heldDownFor++;
						if (heldDownFor > 15) {
								activated = true;
						}
				}

				if (activated) {

						if (Input.GetKey (accelerateKey) || Input.GetKey (KeyCode.D)) {
								Accelerate ();
						}		
						if (Input.GetKey (breakKey) || Input.GetKey (KeyCode.A)) {
								Reverse ();
						}
				} 
		}

		void Accelerate ()
		{
				GetComponent<Velocity> ().AddAcceleration (acceleration);
		}

		void Reverse ()
		{
				GetComponent<Velocity> ().AddAcceleration (-acceleration);
		}
}
