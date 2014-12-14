using UnityEngine;
using System.Collections;

public class CollectablesManager : MonoBehaviour
{
		public int valueIncreasePerCollection = 100;
		private int currentCollectionStreak = 0;
		private static CollectablesManager instance;

		void Awake ()
		{
				instance = this;
		}

		public static int CurrentStreak {
				get {
						return instance.currentCollectionStreak;
				}
		}

		public static int NextCollectionValue {
				get {
						return (instance.currentCollectionStreak + 1) * instance.valueIncreasePerCollection;
				}
		}

		public int CurrentValue {
				get {
						return currentCollectionStreak * valueIncreasePerCollection;
				}
		}

		public static void IncrementStreakAndAddToScore ()
		{
				instance.currentCollectionStreak++;
				Score.Add (instance.CurrentValue);
		}

		public static void ResetCollectionStreak ()
		{
				instance.currentCollectionStreak = 0;
		}
}

