using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeColorChannelSliderScript : MonoBehaviour {

	public Image img;

	public void changeRed(float value){
		img.color = new Color (value, img.color.g, img.color.b, img.color.a);
	}

	public void changeGreen(float value){
		img.color = new Color (img.color.r, value, img.color.b, img.color.a);
	}

	public void changeBlue(float value){
		img.color = new Color (img.color.r, img.color.g, value, img.color.a);
	}

	public void changeAlpha(float value){
		img.color = new Color (img.color.r, img.color.g, img.color.b, value);
	}

	//THERE's MORE SECTION:
	/*

	public Light light;

	public void changeRed(float value){
		light.color = new Color (value, light.color.g, light.color.b, light.color.a);
	}

	public void changeGreen(float value){
		light.color = new Color (light.color.r, value, light.color.b, light.color.a);
	}
	
	public void changeBlue(float value){
		light.color = new Color (light.color.r, light.color.g, value, light.color.a);
	}
	
	public void changeAlpha(float value){
		light.color = new Color (light.color.r, light.color.g, light.color.b, value);
	}
	*/
}
