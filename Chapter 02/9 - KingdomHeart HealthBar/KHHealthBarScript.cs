using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KHHealthBarScript : MonoBehaviour {

	public Image linearBar;
	public Image radialBar;
	
	public int maxHealth = 1000;
	private int health;

	void Start () {
		health = maxHealth;
	}
	
	public void addHealth(int value){
		health += value;
		if (health > maxHealth)
			health = maxHealth;
		updateKHHealthbar ();
	}
	
	//Returns true if the player is die
	public bool removeHealth(int value){
		health -= value;
		if (health <= 0){
			health = 0;
			updateKHHealthbar ();
			return true;
		}
		updateKHHealthbar ();
		return false;
	}

	
	private void updateKHHealthbar () {
		float ratio = health*1f / maxHealth;
		Debug.Log (ratio);
		if (ratio > 0.6) {
			linearBar.fillAmount = (ratio - 0.6f) * 2.5f;
			radialBar.fillAmount = 0.75f;
		} else {
			linearBar.fillAmount = 0;
			radialBar.fillAmount = 0.75f *ratio * 10f / 6f;
		}
	}
}
