using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultibarScript : MonoBehaviour {

	public Image[] bars;

	public int maxHealth = 1000;
	
	private int health;
	
	void Start () {
		health = maxHealth;
	}

	public void addHealth(int value){
		health += value;
		if (health > maxHealth)
			health = maxHealth;
		updateMultibar ();
	}
	
	//Returns true if the player is die
	public bool removeHealth(int value){
		health -= value;
		if (health <= 0){ 
			health = 0;
			updateMultibar ();
			return true;
		}
		updateMultibar ();
		return false;
	}

	private void updateMultibar () {
		float absolute = health*1f/maxHealth;
		float perBars = 1f / bars.Length;
		for (int i=0; i<bars.Length; i++) {
			float minrange = i*perBars;
			float maxrange = (i+1)*perBars;
			if(absolute > minrange){
				if(absolute < maxrange){
					bars[i].fillAmount = (absolute-minrange)*bars.Length;
				}else{
					bars[i].fillAmount = 1;
				}
			}else{
				bars[i].fillAmount = 0;
			}
		}
	}
}
