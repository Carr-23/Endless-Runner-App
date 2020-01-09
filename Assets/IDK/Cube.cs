using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour 
{

	public float speed = 1000f;
	Vector3 temp;

	void start () 
	{

	}

	void Update()
	{
		temp = transform.localScale;
		temp.z += Time.deltaTime*20;
		transform.localScale = temp;
	}
	}


