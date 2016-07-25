using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GraduallyColorSliderScript : MonoBehaviour {

	public Image img;

	public Color firstColor;
	public Color secondColor;
	
	public void change(float value){
		img.color = Color.Lerp(firstColor, secondColor, value);
	}
}
