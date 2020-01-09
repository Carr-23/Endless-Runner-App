using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dis : MonoBehaviour
{	
	public Movement M;
	public GameObject TapToStart;
	public GameObject Gear;
	public GameObject GameOverScreen;
	public GameObject SelectScreen;
	public GameObject Score;
	public GameObject BestScore;

	public swipe S;
	public restart r;
	public Timer tt;
	public Endless E;
	public Endless E1;
	public Endless E2;
	public Endless E3;
	public PlayerCamera pc;

	void Start ()
	{
		//Disable everything before game starts
		M = GameObject.Find ("character").GetComponent<Movement> ();
		M.enabled = false;

		pc = GameObject.Find ("Main Camera").GetComponent<PlayerCamera> ();
		pc.enabled = false;

		S = GameObject.Find ("character").GetComponent<swipe> ();
		S.enabled = false;

		E = GameObject.Find ("platform").GetComponent<Endless> ();
		E.enabled = false;

		E1 = GameObject.Find ("Cube1").GetComponent<Endless> ();
		E1.enabled = false;

		E2 = GameObject.Find ("Cube2").GetComponent<Endless> ();
		E2.enabled = false;

		E3 = GameObject.Find ("Death").GetComponent<Endless> ();
		E3.enabled = false;

		r = GameObject.Find ("GameOver").GetComponent<restart> ();
		r.enabled = false;

		tt = GameObject.Find ("misc").GetComponent<Timer> ();
		tt.enabled = false;

		TapToStart = GameObject.Find ("Button");
		Gear = GameObject.Find ("Button1");
		GameOverScreen = GameObject.Find ("GameOver");
		SelectScreen = GameObject.Find ("CSS");
		Score = GameObject.Find ("Score");
		BestScore = GameObject.Find ("Best");

		GameOverScreen.SetActive (false);
		SelectScreen.SetActive (false);
		Score.SetActive (false);
	}

	//Resetting everything
	void restart ()
	{
		M.enabled = false;
		S.enabled = false;
		E.enabled = false;
		E1.enabled = false;
		E2.enabled = false;
		E3.enabled = false;
		r.enabled = false;
		tt.enabled = false;
		pc.enabled = false;
		TapToStart.SetActive (true);
		Gear.SetActive (true);
		GameOverScreen.SetActive (false);
		Score.SetActive (false);
		BestScore.SetActive (true);
		GameObject.Find ("character").transform.position = new Vector3 (0f, 1.5f, 1.5f);
		GameObject.Find ("Main Camera").transform.position = new Vector3 (0f, 1f, -10f);
		GameObject.Find ("Main Camera").transform.rotation = Quaternion.Euler(0f, 0, 0f);
		GameObject.Find ("platform").transform.position = new Vector3 (0f, 0f, 30f);
		GameObject.Find ("Cube1").transform.position = new Vector3 (-6f, 3f, 25f);
		GameObject.Find ("Cube2").transform.position = new Vector3 (6f, 3f, 25f);
		GameObject.Find ("Death").transform.position = new Vector3 (0f, 3f, -10f);
	}

	//Going to CSS
	public void ButtonInteract0 ()
	{
		SelectScreen.SetActive (true);
		TapToStart.SetActive (false);
	}

	//Exiting CSS
	public void ButtonInteract1 ()
	{
		SelectScreen.SetActive (false);
		TapToStart.SetActive (true);
	}

	//Death screen
	public void Death ()
	{
		E3.enabled = false;
		E2.enabled = false;
		E1.enabled = false;
		E.enabled = false;
		S.enabled = false;
		M.enabled = false;
		GameOverScreen.SetActive (true);
		r.enabled = true;
	}

	//Starting game
	void Update ()
	{
		if (TapToStart.activeInHierarchy == true) {
			if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
				Touch touch = Input.GetTouch (0);
				if (touch.position.y > (Screen.height / 8) *7 & EventSystem.current.IsPointerOverGameObject (Input.GetTouch (0).fingerId)) {
				} else {
					M.enabled = true;
					S.enabled = true;
					E.enabled = true;
					E1.enabled = true;
					E2.enabled = true;
					E3.enabled = true;
					tt.enabled = true;
					pc.enabled = true;

					TapToStart.SetActive (false);
					Gear.SetActive (false);
					Score.SetActive (true);
					BestScore.SetActive (false);
					GameObject.Find ("Button3").SetActive (false);
					GameObject.Find ("Button4").SetActive (false);

					if (PlayerPrefs.GetInt ("Muter", 0) == 1) {
						GameObject.Find ("MU").SetActive (false);
					}
					else
						GameObject.Find ("MU1").SetActive (false);
				}
			}
		}
	}
}
