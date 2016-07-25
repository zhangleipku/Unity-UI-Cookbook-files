using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarTimerScript : MonoBehaviour {

	private Image barFilling;
	
	public float timeAmount = 18f;

	private float time;

	private bool isOver;

	
	void Start () {
		barFilling = this.GetComponent<Image> ();
		time = timeAmount;
	}

	void Update () {
		if (time > 0) {
			time -= Time.deltaTime;
			barFilling.fillAmount = time / timeAmount;
		} else {
			if (!isOver) {
				isOver = true;
				//DO SOMETHING
			}
		}
	}


}