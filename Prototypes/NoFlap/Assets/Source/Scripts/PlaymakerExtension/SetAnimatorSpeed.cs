// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
		[ActionCategory("Animator")]
		[Tooltip("Sets the gravity vector, or individual axis.")]
		public class SetAnimatorSpeed : FsmStateAction
		{
				[RequiredField]
				[CheckForComponent(typeof(Animator))]
				public FsmOwnerDefault
						gameObject;
				public FsmFloat speed;
				public bool everyFrame;
		
				public override void Reset ()
				{
						speed = new FsmFloat { UseVariable = true };
						everyFrame = false;
				}
		
				public override void OnEnter ()
				{
						DoSetSpeed ();
			
						if (!everyFrame)
								Finish ();		
				}
		
				public override void OnUpdate ()
				{
						DoSetSpeed ();
				}
		
				void DoSetSpeed ()
				{
						Fsm.GetOwnerDefaultTarget (gameObject).GetComponent<Animator> ().speed = speed.Value;
				}
		}
}