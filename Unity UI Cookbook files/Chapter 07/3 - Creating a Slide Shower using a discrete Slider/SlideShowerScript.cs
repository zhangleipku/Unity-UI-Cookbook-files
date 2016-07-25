using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlideShowerScript : MonoBehaviour {
	
	void Start () {
		updateSliderSettings ();
	}

	void Update () {
	
	}

	public Sprite[] pictures;

	public Image img;

	public Text label;

	public void changePicture(float value){
		int index = (int)value;
		img.sprite = pictures [index];
		label.text = (index + 1) + "/" + pictures.Length;
	}

	private void updateSliderSettings(){
		Slider slider = GetComponent<Slider> ();
		slider.minValue = 0;
		slider.maxValue = pictures.Length - 1;
		slider.wholeNumbers = true;
		slider.value = 0;
		changePicture (0);
	}
}
