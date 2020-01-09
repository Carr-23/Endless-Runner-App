using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings : MonoBehaviour
{
	GameObject myGameObject;
	GameObject myGameObject1;
	GameObject myGameObject2;
	GameObject myGameObject3;

	AudioSource audioData;

	void Start ()
	{
		PlayerPrefs.SetInt ("Muter", 1);
		audioData = GameObject.Find ("character").GetComponent<AudioSource>();

		myGameObject = GameObject.Find ("MU");
		myGameObject3 = GameObject.Find ("MU1");
		myGameObject1 = GameObject.Find ("Button3");
		myGameObject2 = GameObject.Find ("Button4");
		GameObject.Find ("MU").SetActive (false);
		GameObject.Find ("Button3").SetActive (false);
		GameObject.Find ("MU1").SetActive (false);

		GameObject.Find ("Button4").SetActive (false);
	}

	void Update ()
	{
	}

	public void ButtonInteract ()
	{
		//Settings open and close
		if (myGameObject1.activeInHierarchy == false) {
			if (PlayerPrefs.GetInt ("Muter", 0) == 1)
				myGameObject.SetActive (true);
			
			myGameObject1.SetActive (true);
			myGameObject2.SetActive (true);

			if (PlayerPrefs.GetInt ("Muter", 0) == 2)
				myGameObject3.SetActive (true);
		} else if (GameObject.Find ("Button3").activeInHierarchy == true) {
			if (PlayerPrefs.GetInt ("Muter", 0) == 1)
				GameObject.Find ("MU").SetActive (false);
			if (PlayerPrefs.GetInt ("Muter", 0) == 2)
				GameObject.Find ("MU1").SetActive (false);
			
			GameObject.Find ("Button3").SetActive (false);
			GameObject.Find ("Button4").SetActive (false);
		}
	}

	public void ButtonInteract2 ()
	{
		if (PlayerPrefs.GetInt ("Muter", 0) == 1) {
			myGameObject3.SetActive (true);
			myGameObject.SetActive (false);
			audioData.Pause();

			PlayerPrefs.SetInt ("Muter", 2);
		} else {
			audioData.UnPause();
			myGameObject3.SetActive (false);
			myGameObject.SetActive (true);

			PlayerPrefs.SetInt ("Muter", 1);
		}
	}
}


