using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin : MonoBehaviour
{
	//Not colliding with a wall
	void OnTriggerExit (Collider other)
	{
		GameObject.Find ("character").SendMessage ("Finn1");
	}

	//Colliding with the wall
	void OnTriggerStay (Collider other)
	{
		GameObject.Find ("character").SendMessage ("Finn");
	}
}