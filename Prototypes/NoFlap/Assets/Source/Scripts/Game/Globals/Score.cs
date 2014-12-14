using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Score : MonoBehaviour
{
		private static Score instance;
		private static int highscore = 0;
		private int score = 0;

		void Awake ()
		{
				instance = this;
		}

		public static int CurrentScore {
				get {
						return instance.score;
				}set {
						instance.score = value;
						if (instance.score > highscore) {
								highscore = instance.score;
						}
				}
		}

		public static void Add (int amount)
		{
				instance.score += amount;
		}

		public static int HighScore {
				get {
						return highscore;
				}
		}

		public static void GameOver ()
		{
				if (instance.score > highscore) {
						highscore = instance.score;
				}
		}
}

