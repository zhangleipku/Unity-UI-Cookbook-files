using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MixedTimer : MonoBehaviour {

	private Text uiText;

	private Image barFilling;
	
	public float timeAmount = 18f;
	
	private float time;

	public int decimalDigits = 2;
	

	
	void Start () {
		barFilling = this.GetComponent<Image> ();
		time = timeAmount;
		uiText = this.GetComponentInChildren<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (time > 0) {
			time -= Time.deltaTime;
			if(time < 0 )
				time = 0;
			barFilling.fillAmount = time / timeAmount;
			//uiText.text = "<color=blue>Time</color>: " + time.ToString("F2");
			uiText.text = "<color=blue>Time</color>: " + time.ToString("F"+decimalDigits);
		}
	}
	
	
}