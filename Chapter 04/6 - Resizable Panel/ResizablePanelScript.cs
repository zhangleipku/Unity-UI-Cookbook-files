using UnityEngine;
using System.Collections;

public class ResizablePanelScript : MonoBehaviour {

	Vector2 initialMousePos;
	Vector2 initialDeltaSize;
	
	RectTransform rectTransform;

	void Start () {
		rectTransform = (RectTransform)this.transform;
	}

	public void onDragBegins(){
		initialMousePos = Input.mousePosition;
		initialDeltaSize = rectTransform.sizeDelta;
	}
	
	public void OnDrag(){
		Vector2 temp = (Vector2)initialMousePos - (Vector2)Input.mousePosition;
		temp = new Vector2 (-temp.x, temp.y);
		temp += initialDeltaSize;
		rectTransform.sizeDelta = temp;
	} 

}
