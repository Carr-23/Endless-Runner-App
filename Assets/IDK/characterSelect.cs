using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSelect : MonoBehaviour {

	// Use this for initialization
	public int character;
	void Start () {
		character = PlayerPrefs.GetInt ("CharSelect", 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ButtonInteractLeft ()
	{
		if (PlayerPrefs.GetInt ("CharSelect", 0) > 0) {
			character = character - 1;
		}
		PlayerPrefs.SetInt ("CharSelect", character);
		Debug.Log (character);
	}
	public void ButtonInteractRight ()
	{
		if (PlayerPrefs.GetInt ("CharSelect", 0) < 1) {
			character = character + 1;
		}
		PlayerPrefs.SetInt ("CharSelect", character);
		Debug.Log (character);
	}
}
