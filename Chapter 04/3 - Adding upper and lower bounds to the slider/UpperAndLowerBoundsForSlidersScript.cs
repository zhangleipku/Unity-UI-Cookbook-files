using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Slider))]
public class UpperAndLowerBoundsForSlidersScript : MonoBehaviour {

	private Slider slider;
	public float lowerBound;
	public float upperBound;
	
	void Awake () {
		slider = GetComponent<Slider> ();
		checkBounds ();
	}
		
	public void checkBounds () {
		if(slider.value >= upperBound){
			slider.value = upperBound;
		} else {
			if(slider.value <= lowerBound){
				slider.value = lowerBound;
			}
		}
	}
}
