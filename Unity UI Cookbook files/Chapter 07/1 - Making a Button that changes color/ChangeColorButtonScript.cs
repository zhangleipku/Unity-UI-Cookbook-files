using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeColorButtonScript : MonoBehaviour {

	public Color color;
	private Color originalColor;

	private Image img;

	private bool b;

	void Start () {
		img = GetComponent<Image> ();
		originalColor = img.color;
	}
	

	void Update () {
	
	}

	public void onClick(){
		if (b)
			img.color = color;
		else
			img.color = originalColor;
		b = !b;
	}
}
