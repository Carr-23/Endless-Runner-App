using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;


public class VirtualJoystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IDragHandler
{
	private Image bgImg;
	private Image jsImg;

	private void start()
	{
		bgImg = GetComponent<Image> ();
		jsImg = GetComponentInChildren<Image> ();
	}

	public virtual void OnDrag (PointerEventData eventData)
	{
		Debug.Log ("hi");
	}

	public virtual void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log ("h1i");
	}

	public virtual void OnPointerUp(PointerEventData eventData)
	{
		Debug.Log ("h2i");
	}
    
}
