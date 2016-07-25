using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WellFormattedTimerScript : MonoBehaviour {

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
		string minutes = Mathf.Floor(time / 60).ToString("00");
		string seconds = (time % 60).ToString("00");
		uiText.text = "<color=blue>Time</color>: " + minutes + ":" + seconds;
	}
}
