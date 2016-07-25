using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExtendableElementScript : MonoBehaviour {

	public float speed;
	public float surviveTime;

	private float x, y;
	private RectTransform rectTransform;
	private Vector2 originalSizeDelta;
	
	void Start () {
		rectTransform = GetComponent<RectTransform> ();
		GetComponent<Image>().CrossFadeAlpha(0f, surviveTime, false);

		/* There's more part
		GetComponent<Image>().CrossFadeAlpha(0f, 0f, false);
		GetComponent<Image>().CrossFadeAlpha(1f, surviveTime, false);
		*/

		originalSizeDelta = rectTransform.sizeDelta;
		GameObject.Destroy(gameObject, surviveTime);
	}

	void Update () {
		x += speed * Time.deltaTime;
		y += speed * Time.deltaTime;
		rectTransform.sizeDelta = new Vector2(x, y) + originalSizeDelta;
	}
}
