using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class SceneAdvertisement : MonoBehaviour
{
		private const string appID = "20593";
		public static string zone_id = "pictureZone";
		public const string PictureZone = "pictureZone";
		public const string DefaultVideoAndPictureZone = "defaultVideoAndPictureZone";
		private static int AdsShown = 0;
		public const int PictureAddsPerVideoAdd = 3;

		void Awake ()
		{
				if (Advertisement.isSupported) {
						Advertisement.allowPrecache = true;
						Advertisement.Initialize (appID);
				} else {
						Debug.Log ("Platform not supported");
				}
		}

		public static void Show ()
		{
				string zone_id = PictureZone;
				if ((AdsShown + 1) % PictureAddsPerVideoAdd == 0) {
						zone_id = DefaultVideoAndPictureZone;
				}
				Advertisement.Show (zone_id, new ShowOptions {
					pause = true,
					resultCallback = result => {
					Debug.Log(result.ToString());
					}
					});
				AdsShown++;
		}
}

