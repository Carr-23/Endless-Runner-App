using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCharacter : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if ((PlayerPrefs.GetInt ("CharSelect", 0) == 1)) {
			Destroy (GameObject.Find ("Peng"));
		} else if ((PlayerPrefs.GetInt ("CharSelect", 0) == 0)) {
			Destroy (GameObject.Find ("Peng2"));
		}
	}
}
