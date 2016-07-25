using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumericTimerScript : MonoBehaviour {

	private Text uiText;
	
	private float time = 0;

	//There's more...
	public float getTime(){
		return time;
	}

	void Start () {
		uiText = this.GetComponent<Text> ();
	}

	void Update () {
		time += Time.deltaTime;
		uiText.text = "<color=blue>Time</color>: " + time.ToString("F2");
	}
}
