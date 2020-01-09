using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class playAd : MonoBehaviour
{

	// Use this for initialization
	void adPlay ()
	{
		if (Advertisement.IsReady())
			Advertisement.Show ("video", new ShowOptions(){resultCallback = HandleAdResult});
	}

	void adPlay1 ()
	{
		if (Advertisement.IsReady())
			Advertisement.Show ("rewardedVideo", new ShowOptions(){resultCallback = HandleAdResult1});
	}

	private void HandleAdResult(ShowResult result){
		switch (result) {

		case ShowResult.Finished:
			GameObject.Find ("GameOver").SendMessage ("okNow");
			break;
		case ShowResult.Skipped:
			GameObject.Find ("GameOver").SendMessage ("okNow");
			break;
		case ShowResult.Failed:
			GameObject.Find ("GameOver").SendMessage ("okNow");
			break;		
		}
	}

	private void HandleAdResult1(ShowResult result1){
		switch (result1) {

		case ShowResult.Finished:
			GameObject.Find ("GameOver").SendMessage ("andNow");
			break;
		case ShowResult.Skipped:
			GameObject.Find ("GameOver").SendMessage ("okNow");
			break;
		case ShowResult.Failed:
			GameObject.Find ("GameOver").SendMessage ("okNow");
			break;		
		}
	}
}
