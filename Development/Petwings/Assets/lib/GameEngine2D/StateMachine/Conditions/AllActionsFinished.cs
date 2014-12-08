using UnityEngine;
using System.Collections;

public class AllActionsFinished : TransitionCondition
{
		public State state;

		public override bool Met {
				get {
						foreach (MultiFrameAction multiFrameAction in state.multiFrameActions) {
								if (multiFrameAction.HasFinished == false) {
										return false;
								}
						}
						return true;
				}
		}
}

