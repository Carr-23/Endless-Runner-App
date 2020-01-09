using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class model0 : MonoBehaviour
{

	public float moveSpeed;
	public float directionSpeed;
	public float setup;
	public Quaternion originalRotationValue;
	public int rdm;

	// Use this for initialization
	void Start ()
	{
		moveSpeed = 10;
		directionSpeed = 11f;
		//originalRotationValue = transform.rotation;
		rdm = 1;
		PlayerPrefs.SetInt ("RDM", rdm);
	}

	// Update is called once per frame
	void Update ()
	{
		transform.Translate (directionSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, directionSpeed * Input.GetAxis ("Vertical") * Time.deltaTime); 
		//transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * 1.0f); 
	}

	public void end()
	{
		setup = (int)Random.Range (1.0f, 8.0f);

		if (setup == 1) {
			GameObject.Find ("object2").transform.position = new Vector3 (-3.5f, 11.75f, 8f);
			rdm = 2;
			PlayerPrefs.SetInt ("RDM", rdm);
		} else if (setup == 2) {
			GameObject.Find ("object").transform.position = new Vector3 (0.0f, 11.75f, 8f);
			GameObject.Find ("object2").transform.position = new Vector3 (-3.5f, 11.75f, 8f);
			rdm = 2;
			PlayerPrefs.SetInt ("RDM", rdm);
		}else if (setup == 3) {
			GameObject.Find ("object1").transform.position = new Vector3 (3.5f, 11.75f, 8f);
			GameObject.Find ("object2").transform.position = new Vector3 (-3.5f, 11.75f, 8f);
			rdm = 2;
			PlayerPrefs.SetInt ("RDM", rdm);
		}else if (setup == 4) {
			GameObject.Find ("object1").transform.position = new Vector3 (3.5f, 11.75f, 8f);
			GameObject.Find ("object2").transform.position = new Vector3 (-3.5f, 11.75f, 8f);
			GameObject.Find ("object").transform.position = new Vector3 (0.0f, 11.75f, 8f);
			rdm = 2;
			PlayerPrefs.SetInt ("RDM", rdm);
		}else if (setup == 5) {
			GameObject.Find ("object").transform.position = new Vector3 (0.0f, 11.75f, 8f);
			rdm = 1;
			PlayerPrefs.SetInt ("RDM", rdm);
		}else if (setup == 6) {
			GameObject.Find ("object1").transform.position = new Vector3 (3.5f, 11.75f, 8f);
			GameObject.Find ("object").transform.position = new Vector3 (0.0f, 11.75f, 8f);
			rdm = 3;
			PlayerPrefs.SetInt ("RDM", rdm);
		}else if (setup == 7) {
			GameObject.Find ("object1").transform.position = new Vector3 (3.5f, 11.75f, 8f);
			rdm = 3;
			PlayerPrefs.SetInt ("RDM", rdm);
		}
		PlayerPrefs.SetInt ("Speed", (PlayerPrefs.GetInt ("Speed", 0))+1);
	}
}﻿