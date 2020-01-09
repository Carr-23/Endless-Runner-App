using UnityEngine;
using System.Collections;

public class swipe : MonoBehaviour
{
	float speed;
	public Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		speed = 0.3F;
	}

	void FixedUpdate ()
	{
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);

			if (transform.position.y == 1.25) { 
				//Jump high
				if (touch.position.y > (Screen.height / 8) * 4) {
					rb.AddForce (0, 470, 0);
				}
				//Jump low
				else if (touch.position.y < (Screen.height / 8)) {
					rb.AddForce (0, 350, 0);
				}
			}

			//Movement with touch
			if (Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				rb.AddForce (touchDeltaPosition.x * speed, 0, 0, ForceMode.VelocityChange);
			}
		}

		//Bring up if goes through platform
		if (transform.position.y < 1.25) {
			transform.position = new Vector3 (transform.position.x, 1.25f, transform.position.z); 
		}
	}
}