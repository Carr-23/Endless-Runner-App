using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using TMPro;

public class HIGHscore : MonoBehaviour
{
	//public Text highScore;
	public TextMeshProUGUI hs;
	void start()
	{
		hs = GameObject.Find ("Best").GetComponent<TextMeshProUGUI> ();
	}

	void Update ()
	{
		hs.text = "Best:" + PlayerPrefs.GetInt ("HighScoreS", 0).ToString ("f0");
	}

}
