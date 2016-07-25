using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDBarScript : MonoBehaviour {

	private Image uiImage;
	public float startFilling;
	public float maximumStretch;
	public float phase;
	
	void Start () {
		uiImage = GetComponent<Image> ();
	}

	void Update () {
		uiImage.fillAmount = startFilling +((Mathf.Sin (phase + Time.time + Random.value/200f) + 1f) / 2f) * maximumStretch;
	}
}
