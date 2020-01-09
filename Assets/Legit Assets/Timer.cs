using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
	public TextMeshProUGUI ttx;

	int hsS;
	private float startTime;
	private bool finnished = false;
	float t;
	int count;

	void Start ()
	{
		count = 1;
		ttx = GameObject.Find ("Score").GetComponent<TextMeshProUGUI> ();
	}

	void Update ()
	{
		if (finnished) {
			count = 1;
			return;
		}
		
		if (count == 1) { 
			startTime = Time.time;
			count = 2;
		}

		t = Time.time - startTime;
		string seconds = ((int)Math.Ceiling(t % 60)).ToString ("f0");

		ttx.text = (seconds);
	}

	public void Finnish ()
	{
		hsS = (int)Math.Ceiling((t % 60));
			if (hsS > PlayerPrefs.GetInt ("HighScoreS", 0)) {
				PlayerPrefs.SetInt ("HighScoreS", hsS);
			}

		finnished = true;
		ttx.color = Color.white;
	}

	public void Reset(){
		ttx.color = Color.black;
		finnished = false;
	}
}
