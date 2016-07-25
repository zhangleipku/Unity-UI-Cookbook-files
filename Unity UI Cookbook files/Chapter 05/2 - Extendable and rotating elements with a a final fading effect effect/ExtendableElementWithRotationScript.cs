using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExtendableElementWithRotationScript : MonoBehaviour {

	public float speed;
	public float rotationSpeed;
	public float surviveTime;

	private float x, y;
	private RectTransform rectTransform;
	private Vector2 originalSizeDelta;
	
	void Start () {
		rectTransform = GetComponent<RectTransform> ();
		GetComponent<Image>().CrossFadeAlpha(0f, surviveTime, false);
		originalSizeDelta = rectTransform.sizeDelta;
		GameObject.Destroy(gameObject, surviveTime);
	}

	void Update () {
		x += speed * Time.deltaTime;
		y += speed * Time.deltaTime;
		rectTransform.sizeDelta = new Vector2(x, y) + originalSizeDelta;
		rectTransform.Rotate (0,0 , Time.deltaTime * rotationSpeed);
	}
}
