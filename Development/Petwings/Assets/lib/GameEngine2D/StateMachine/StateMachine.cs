using UnityEngine;
using System.Collections;

public class StateMachine : MonoBehaviour
{
		public State activeState;

		void FixedUpdate ()
		{
				foreach (StateTransition transition in activeState.transitions) {
						foreach (TransitionCondition condition in transition.conditions) {
								if (condition.Met) {
										foreach (MultiFrameAction multiFrameAction in activeState.multiFrameActions) {
												multiFrameAction.Interrupted ();
										}
										activeState = transition.destination;
										foreach (MultiFrameAction action in activeState.multiFrameActions) {
												action.Start ();
										}
										foreach (SingleFrameAction action in activeState.singleFrameActions) {
												action.Run ();
										}
								}
						}
				}
				foreach (MultiFrameAction multiFrameAction in activeState.multiFrameActions) {
						if (multiFrameAction.HasFinished == false) {
								multiFrameAction.Run ();
						}
				}
		}
}
