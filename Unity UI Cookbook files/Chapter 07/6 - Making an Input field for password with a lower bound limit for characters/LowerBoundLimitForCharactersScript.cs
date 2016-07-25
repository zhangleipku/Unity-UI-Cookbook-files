using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LowerBoundLimitForCharactersScript : MonoBehaviour {

	private InputField inputField;
	public int characterLimit;

	void Start () {
		inputField = GetComponent<InputField> ();
	}
	
	public void Check (string newText) {
		if(newText.Length < characterLimit){
			inputField.text = "";
		}
	}


}
