using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class AnimatingCursorScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Texture2D[] cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	public float secondsBetweenFrames;

	public void OnPointerEnter(PointerEventData eventData){
		StartCoroutine (animateCursor());
	}

	public void OnPointerExit(PointerEventData eventData){
		StopCoroutine (animateCursor());
		Cursor.SetCursor(null, Vector2.zero, cursorMode);
	}

	IEnumerator animateCursor(){
		while (true) {
			for(int i = 0; i<cursorTexture.Length; i++){
				Cursor.SetCursor(cursorTexture[i], hotSpot, cursorMode);
				yield return new WaitForSeconds(secondsBetweenFrames);
			}
		}
	}
}
