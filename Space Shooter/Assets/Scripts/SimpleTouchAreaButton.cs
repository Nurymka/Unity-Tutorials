using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class SimpleTouchAreaButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	private bool touched;
	private int pointerID;
	private bool canFire;

	void Awake () {
		touched = false;
	}

	public void OnPointerDown (PointerEventData data) {
		// set our start point
		if (!touched) {
			touched = true;
			pointerID = data.pointerId;
			canFire = true;
		}
	}

	public void OnPointerUp (PointerEventData data) {
		// reset everything
		if (data.pointerId == pointerID) {
			touched = false;
			canFire = false;
		}
	}

	public bool CanFire () {
		return canFire;
	}
}
