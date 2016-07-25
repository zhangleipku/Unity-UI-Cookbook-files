using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangingCountdownScript : MonoBehaviour {

	
	private Text uiText;
	
	public float time = 65;
	
	private bool isOver;
	
	//There's more...
	public float getTime(){
		return time;
	}
	
	void Start () {
		uiText = this.GetComponent<Text> ();
	}
	
	void Update () {
		time -= Time.deltaTime;
		if (Mathf.Floor (time / 60) >= 1) {
			string minutes = Mathf.Floor (time / 60).ToString ("00");
			string seconds = (time % 60).ToString ("00");
			uiText.text = "<color=blue>Time</color>: " + minutes + ":" + seconds;
		} else {
			if(time>=10){
				uiText.text = "<color=blue>Time</color>: " + time.ToString("F0");
			}else{
				if(time <= 0){
					uiText.text = "<color=blue>Time</color>: <color=red>0</color>";
					if(!isOver){
						isOver = true;
						//DO SOMETHING
					}
				}else {
					uiText.text = "<color=blue>Time</color>: <color=red>" + time.ToString("F0")+"</color>";
				}
			}
		}
	}

}
