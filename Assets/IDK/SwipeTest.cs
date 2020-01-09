using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeTest : MonoBehaviour

{
	public Swipe swipeControls;
	public Transform model;
	private Vector3 desiredPosition;

	private void Update()
	{
		if (swipeControls.SwipeLeft)
			desiredPosition += Vector3.left;
		if (swipeControls.SwipeRight)
			desiredPosition += Vector3.right;

		model.transform.position = Vector3.MoveTowards(model.transform.position, desiredPosition, 11f * Time.deltaTime);

	}

}
