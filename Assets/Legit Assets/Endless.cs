using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless : MonoBehaviour
{
	float moveSpeed;

	void Start ()
	{
		moveSpeed = 10;
	}

	void FixedUpdate ()
	{
		//Autorun for walls
		transform.Translate (0f, 0f, moveSpeed * Time.deltaTime ); 
	}
}