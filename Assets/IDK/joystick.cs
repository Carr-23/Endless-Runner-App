using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class joystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler {

	private Image bgImg;
	private Image jsImg;
	private Vector3 inputVector;

	private void start ()
	{
		bgImg = GetComponent<Image>();
		jsImg = transform.GetChild (0).GetComponent<Image> ();
	}

	public virtual void OnDrag (PointerEventData ped){
		Vector2 pos;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle
			(   bgImg.rectTransform,
				ped.position,
				ped.pressEventCamera,
				out pos)) {
			Debug.Log ("sa dude");
		}

	}

	public virtual void OnPointerDown(PointerEventData ped){
		OnDrag (ped);
	}

	public virtual void OnPointerUp(PointerEventData ped){
	}

}
