using UnityEngine;
using System;

namespace GameUtil2D
{
		public static class MouseUtil2D
		{
				public static void FaceMouse (GameObject gameObject)
				{
						Vector3 screenPos = Camera.main.WorldToScreenPoint (gameObject.transform.position);
						gameObject.transform.rotation = Quaternion.Euler (0, 0, Mathf.Atan2 (Input.mousePosition.y - screenPos.y, Input.mousePosition.x - screenPos.x) * Mathf.Rad2Deg - 90);
				}
		}

		public static class PhysicsUtil2D
		{
				public static void ApplyForwardForce (Rigidbody2D rigidBody2D, float amount)
				{
						ApplyDirectedForce (rigidBody2D, rigidBody2D.transform.rotation, amount);
				}

				public static void ApplyDirectedForce (Rigidbody2D rigidBody2D, Quaternion rotation, float amount)
				{
						rigidBody2D.AddForce (rotation * Vector3.up * amount);
				}

				public static void ApplyForceTowards (Rigidbody2D rigidBody2D, Vector3 position, float speed)
				{
					
				}

				public static void TranslateForwards (Rigidbody2D rigidBody2d, float distance)
				{						
						Vector2 velocity = GetVelocity (Mathf.Deg2Rad * rigidBody2d.rotation, distance);
						rigidBody2d.transform.position += new Vector3 (velocity.x, velocity.y, 0);
				}

				public static Vector2 GetVelocity (float radions, float speed)
				{
						float opp = (float)(speed * Math.Sin (radions));
						float adj = (float)(speed * Math.Cos (radions));
						return new Vector2 (adj, opp);
				}
		}

		public static class CameraUtil2D
		{
				public static void SetZ (float z)
				{
						Vector3 cameraPosition = Camera.main.transform.position;
						cameraPosition.Set (cameraPosition.x, cameraPosition.y, z);
						Camera.main.transform.position = cameraPosition;
				}
		}

		public static class StageUtil
		{	
				
				public static GameObject AddGameObject (Sprite sprite)
				{
						GameObject gameObject = new GameObject ();
						SpriteRenderer renderer = gameObject.AddComponent<SpriteRenderer> ();
						renderer.sprite = sprite;
						return gameObject;
				}

				public static GameObject AddGameObject (String texture)
				{
						return AddGameObject (Resources.LoadAssetAtPath<Sprite> (texture));			
				}						
		}

		public static class Asset2DUtil
		{
				public static Sprite Circle01 {
						get {
								return LoadTexture ("shapes/circle01.png");									
						}
				}
			
				public static Sprite LoadTexture (String filename)
				{
						return Resources.LoadAssetAtPath<Sprite> ("Assets/textures/" + filename);		
				}
		}
}

