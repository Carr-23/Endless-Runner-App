using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loss : MonoBehaviour {

	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Peng") {
			GameObject.Find ("Peng").SendMessage ("Finnish");
		}
	}
}
