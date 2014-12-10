using UnityEngine;
using System.Collections;

namespace Petwings.Engine.Base
{
		public class Player : MonoBehaviour
		{
				public static Player Instance;
				private Animator animator;
				public bool alive = true;

				void Awake ()
				{
						Player.Instance = this;
						animator = GetComponent<Animator> ();
				}

				public void Die ()
				{
						alive = false;
						animator.SetTrigger ("Die");
				}

				public void Dazzle(){
						animator.SetTrigger ("Dazzle");
        		}

				public void FlyLeft(){

				}

				void FixedUpdate(){
					
				}

				public void Remove ()
				{
						GameObject.Destroy (gameObject);
				}
		}
}
