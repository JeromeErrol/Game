// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
		[ActionCategory("New UI")]
		[Tooltip("Writes out the text value to a text object")]
		public class WriteText : FsmStateAction
		{
				[RequiredField]
				[CheckForComponent(typeof(Text))]
				public FsmOwnerDefault
						gameObject;
				public FsmString text;
				public bool everyFrame;
				public FsmFloat framesBetweenLetters;
				private float nextLetter;
				private int currentIndex;
				public FsmEvent finishEvent;
        
				public override void Reset ()
				{
						gameObject = null;
						text = "";
						currentIndex = 1;
						framesBetweenLetters = new FsmFloat { UseVariable = true };
						nextLetter = framesBetweenLetters.Value;

				}
		
				public override void OnEnter ()
				{
						if (!everyFrame) {
								SetTextInSingleFrame ();
								Finish ();
						} 
				}
		
				public override void OnUpdate ()
				{
						WriteTextOverTime ();
				}
		
				void SetTextInSingleFrame ()
				{
						SetTextValue (text.Value);
				}

				void SetTextValue (string value)
				{
						GameObject go = Fsm.GetOwnerDefaultTarget (gameObject);
						Text text_ = go.GetComponent<Text> ();
						if (text_ != null) {
								text_.text = value;
						}
				}
        
				void WriteTextOverTime ()
				{
						if (nextLetter <= 0) {
								nextLetter = framesBetweenLetters.Value;
								if (currentIndex <= text.Value.Length) {
										string newText = text.Value.Substring (0, currentIndex);
										SetTextValue (newText);
										currentIndex++;
								} else {
										Finish ();
								}
						} else {
								nextLetter--;	
						}
				}
		}
}