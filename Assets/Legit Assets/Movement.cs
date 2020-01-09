using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public float moveSpeed;
	float directionSpeed;
	float resetTime;

	void Start ()
	{
		moveSpeed = 10;
		directionSpeed = 11f;
	}

	void FixedUpdate ()
	{
		//Keyboard movement
		transform.Translate (directionSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, directionSpeed * Input.GetAxis ("Vertical") * Time.deltaTime,0f); 
		//Auto RUn
		transform.Translate (0f, 0f, moveSpeed * Time.deltaTime ); 
	}

	public void Finn ()
	{
		moveSpeed = 0;
	}

	public void Finn1 ()
	{
		moveSpeed = 10;
	}
}