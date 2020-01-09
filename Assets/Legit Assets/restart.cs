using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class restart : MonoBehaviour
{
	//Going to menu after death

	public RectTransform Load;
	public RectTransform Load1;

	int count;
	int played;
	private float startTime;
	void Start(){
		Load = GameObject.Find ("Load1").GetComponent<RectTransform>();
		Load1 = GameObject.Find ("Load2").GetComponent<RectTransform>();
		Load.sizeDelta = new Vector2 (1500f, 0f);
		Load1.sizeDelta = new Vector2 (1500f, 0f);
		count = 8;
		played = 1;
	}

	void Update ()
	{

		if (count == 8) { 
			startTime = Time.time;
			count = 4;
		}

		if (count == 3){
			GameObject.Find ("GameOver").SetActive (false);
			Debug.Log ("yay play again");
		}

		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began && count == 2) {
			GameObject.Find ("misc").SendMessage ("restart");
			GameObject.Find ("misc").SendMessage ("Reset");
			count = 8;
			played = 2;
		}

		if ((startTime - Time.time) * 50f < 1150 && count == 2) {
			Load.sizeDelta = new Vector2 (1500f, (Time.time - startTime) * 50f);
			Load1.sizeDelta = new Vector2 (1500f, (Time.time - startTime) * 50f);
		}
		else if ((Time.time - startTime) * 50f > 1150 && count == 2 && played == 1){
			noWait ();
		}
	}

	public void noWait(){
		count = 1;
		GameObject.Find ("GameOver").SendMessage ("adPlay1");
		played = 2;
	}

	void okNow (){
		count = 2;
	}

	void andNow (){
		count = 3;
	}
}