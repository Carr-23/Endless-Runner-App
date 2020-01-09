using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
	//Rigidbody rigid;
	public float moveForce = 10;
	public int test = 0;
	bool isJumping;

	private void Start ()
	{
		//rigid = this.GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		float step = 10 * Time.deltaTime;
		//Vector2 moveVec = new Vector2 (CrossPlatformInputManager.GetAxis ("Horizontal"), CrossPlatformInputManager.GetAxis ("Vertical"));
		if (transform.position.y <= 10.4218f & transform.position.y > 10.4216f) {
			//isJumping = CrossPlatformInputManager.GetButton ("Jump");
		}
		//transform.Translate (moveForce * CrossPlatformInputManager.GetAxis ("Horizontal") * Time.deltaTime, 0f, moveForce * CrossPlatformInputManager.GetAxis ("Vertical") * Time.deltaTime); 

		if (isJumping == true) {
			test = 1;
		}

		if (test == 1) {
			transform.Translate (0f, step, 0f);
		}
		if (transform.position.y > 12.7f)
		{
			test = 0;
			isJumping = false;
		}
	}
  
}
