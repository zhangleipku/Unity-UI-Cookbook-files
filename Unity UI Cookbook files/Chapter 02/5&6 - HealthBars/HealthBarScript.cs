using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBarScript : MonoBehaviour {

	private Image healthbarFilling;

	public int maxHealth = 100;

	private int health;

	//There's more... of Radial Bar
	// public float startingFilling  = 1;

	
	void Start () {
		healthbarFilling = this.GetComponent<Image> ();
		health = maxHealth;
	}
	
	public void addHealth(int value){
		health += value;
		if (health > maxHealth)
			health = maxHealth;
		updateHealth ();
	}

	//Returns true if the player is die
	public bool removeHealth(int value){
		health -= value;
		if (health <= 0){ 
			health = 0;
			updateHealth ();
			return true;
		}
		updateHealth ();
		return false;
	}

	private void updateHealth(){
		healthbarFilling.fillAmount = health / maxHealth;  //aafter the modification in There's more... part: healthbarFilling.fillAmount = (health / maxHealth)*startingFilling ;
	}
}
