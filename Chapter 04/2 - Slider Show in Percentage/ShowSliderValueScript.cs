using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class ShowSliderValueScript : MonoBehaviour {

	private Text uiText;
	
	void Start () {
		uiText = GetComponent<Text>();
	}

	public void updateValue(float value){
		uiText.text = Mathf.RoundToInt (value * 100) + "%";
	}
}
