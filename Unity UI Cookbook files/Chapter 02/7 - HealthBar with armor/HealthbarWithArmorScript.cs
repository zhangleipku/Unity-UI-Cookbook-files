using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthbarWithArmorScript : MonoBehaviour {

	public GameObject[] armor;
	private int piecesOfArmor;

	private Image healthbarFilling;
	
	public int maxHealth = 100;
	
	private int health;
	
	
	
	void Start () {
		healthbarFilling = this.GetComponent<Image> ();
		health = maxHealth;
		piecesOfArmor = armor.Length;
	}

	public void addArmor(){
		if (piecesOfArmor < armor.Length) {
			piecesOfArmor++;
			updateArmor();
		}
	}

	public bool damage(int value){
		if (piecesOfArmor > 0) {
			piecesOfArmor--;
			updateArmor();
			return false;
		}else{
			return damageIgnoringArmor(value);
		}
	}

	//Returns true if the player is die
	public bool damageIgnoringArmor(int value){
		health -= value;
		if (health <= 0){
			health = 0;
			updateHealthbar ();
			return true;
		}
		updateHealthbar ();
		return false;
	}

	public void addHealth(int value){
		health += value;
		if (health > maxHealth)
			health = maxHealth;
		updateHealthbar ();
	}

	public void updateHealthbar(){
		healthbarFilling.fillAmount = health / maxHealth;
	}

	public void updateArmor(){
		for (int i=0; i<armor.Length; i++) {
			if(i<piecesOfArmor){
				armor[i].SetActive(true);
			}else{
				armor[i].SetActive(false);
			}
		}
	}

}
