using UnityEngine;
using System.Collections;

public class FloatingUIScript : MonoBehaviour {

	private RectTransform rectTransform;
	public float xspeed, xAmplitude, yspeed, yAmplitude;
	
	void Start () {
		rectTransform = GetComponent<RectTransform> ();
	}

	void Update () {
		rectTransform.localPosition = new Vector3(xAmplitude*Mathf.Sin(Time.time*xspeed), yAmplitude*Mathf.Sin(Time.time*yspeed), 0); 
	}
}
