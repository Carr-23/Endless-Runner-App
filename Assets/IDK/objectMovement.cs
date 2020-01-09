using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMovement : MonoBehaviour
{

	public float resetTime = 0;
	//
	public Quaternion originalRotationValue;

	// Use this for initialization
	void Start ()
	{
		//originalRotationValue = transform.rotation;
		PlayerPrefs.SetInt ("Speed", 7);
	}

	void SetTransformX ()
	{
		//transform.rotation = Quaternion.Slerp (transform.rotation, originalRotationValue, Time.time * 1.0f); 
		resetTime = Time.deltaTime;
		transform.Translate (0f, 0f, -(7 + (0.25f * (PlayerPrefs.GetInt ("Speed", 0) - 7f))) * Time.deltaTime - resetTime); 
		Physics.IgnoreLayerCollision (28, 30);
		Physics.IgnoreLayerCollision (28, 29);
		Debug.Log ((5 + (0.25f * (PlayerPrefs.GetInt ("Speed", 0) - 5f))));
	}

	// Update is called once per frame
	void Update ()
	{
		SetTransformX ();
	}
}﻿