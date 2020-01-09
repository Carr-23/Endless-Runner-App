using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colours : MonoBehaviour {

	void Start(){
		if (PlayerPrefs.GetInt ("colour", 0) == 1)
			red ();
		else if (PlayerPrefs.GetInt ("colour", 0) == 2)
			blue ();
		else if (PlayerPrefs.GetInt ("colour", 0) == 3)
			green ();
	}


	public void red(){
		PlayerPrefs.SetInt ("colour", 1);

		GameObject.Find ("character").GetComponent<Renderer> ().material.color = new Color (163/255f,0/255f,30/255f);
		GameObject.Find ("platform").GetComponent<Renderer> ().material.color = new Color (246/255f,97/255f,28/255f);
		GameObject.Find ("Cube1").GetComponent<Renderer> ().material.color = new Color (188/255f,27/255f,8/255f);
		GameObject.Find ("Cube2").GetComponent<Renderer> ().material.color = new Color (188/255f,27/255f,8/255f);

		GameObject.Find ("Cube").GetComponent<Renderer> ().material.color = new Color (242/255f,163/255f,0/255f);
		GameObject.Find ("Cube (1)").GetComponent<Renderer> ().material.color = new Color (242/255f,163/255f,0/255f);
		GameObject.Find ("Cube (2)").GetComponent<Renderer> ().material.color = new Color (242/255f,163/255f,0/255f);
		GameObject.Find ("Cube (3)").GetComponent<Renderer> ().material.color = new Color (242/255f,163/255f,0/255f);
		GameObject.Find ("Cube (4)").GetComponent<Renderer> ().material.color = new Color (242/255f,163/255f,0/255f);

	}

	public void blue(){
		PlayerPrefs.SetInt ("colour", 2);

		GameObject.Find ("character").GetComponent<Renderer> ().material.color = new Color (6f/255f,190f/255f,255f/255f);
		GameObject.Find ("platform").GetComponent<Renderer> ().material.color = new Color (1,1,1);
		GameObject.Find ("Cube1").GetComponent<Renderer> ().material.color = new Color (23/255f,104f/255f,172f/255f);
		GameObject.Find ("Cube2").GetComponent<Renderer> ().material.color = new Color (23/255f,104f/255f,172f/255f);

		GameObject.Find ("Cube").GetComponent<Renderer> ().material.color = new Color (3/255f,37/255f,104/255f);
		GameObject.Find ("Cube (1)").GetComponent<Renderer> ().material.color = new Color (3/255f,37/255f,104/255f);
		GameObject.Find ("Cube (2)").GetComponent<Renderer> ().material.color = new Color (3/255f,37/255f,104/255f);
		GameObject.Find ("Cube (3)").GetComponent<Renderer> ().material.color = new Color (3/255f,37/255f,104/255f);
		GameObject.Find ("Cube (4)").GetComponent<Renderer> ().material.color = new Color (3/255f,37/255f,104/255f);

	}

	public void green(){
		PlayerPrefs.SetInt ("colour", 3);

		GameObject.Find ("character").GetComponent<Renderer> ().material.color = new Color (176/255f,254/255f,118/255f);
		GameObject.Find ("platform").GetComponent<Renderer> ().material.color = new Color (143/255f,187/255f,153/255f);
		GameObject.Find ("Cube1").GetComponent<Renderer> ().material.color = new Color (54/255f,54/255f,53/255f);
		GameObject.Find ("Cube2").GetComponent<Renderer> ().material.color = new Color (54/255f,54/255f,53/255f);

		GameObject.Find ("Cube").GetComponent<Renderer> ().material.color = new Color (129/255f,233/255f,121/255f);
		GameObject.Find ("Cube (1)").GetComponent<Renderer> ().material.color = new Color (129/255f,233/255f,121/255f);
		GameObject.Find ("Cube (2)").GetComponent<Renderer> ().material.color = new Color (129/255f,233/255f,121/255f);
		GameObject.Find ("Cube (3)").GetComponent<Renderer> ().material.color = new Color (129/255f,233/255f,121/255f);
		GameObject.Find ("Cube (4)").GetComponent<Renderer> ().material.color = new Color (129/255f,233/255f,121/255f);
	}
}
