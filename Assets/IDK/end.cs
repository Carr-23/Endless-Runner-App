using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{

	// Use this for initialization
	private void OnTriggerEnter (Collider other)
	{
		if ((other.gameObject.tag == "object") & PlayerPrefs.GetInt ("RDM", 0)==1) {
			GameObject.Find ("Peng").SendMessage ("end");
		}
		if ((other.gameObject.tag == "object1") & PlayerPrefs.GetInt ("RDM", 0)==3) {
			GameObject.Find ("Peng").SendMessage ("end");
		}
		if ((other.gameObject.tag == "object2") & PlayerPrefs.GetInt ("RDM", 0)==2) {
			GameObject.Find ("Peng").SendMessage ("end");
		}
	
	}
}

