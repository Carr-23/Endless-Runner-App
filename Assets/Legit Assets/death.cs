using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class death : MonoBehaviour
{
	//Death triggered
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "p1"){
			GameObject.Find ("misc").SendMessage ("Death");
			GameObject.Find ("misc").SendMessage ("Finnish");
			GameObject.Find ("GameOver").SendMessage ("adPlay");
		}
	}
}