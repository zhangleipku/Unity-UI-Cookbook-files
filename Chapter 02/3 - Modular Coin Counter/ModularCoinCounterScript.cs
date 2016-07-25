using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ModularCoinCounterScript : MonoBehaviour {

	private Text uiText;

	public int maxCoins = 100;
	private int coins = 0;

	//There's more
	public int getCoins(){
		return coins;
	}

	void Start () {
		uiText = this.GetComponent<Text> ();
		updateCoinCounter ();
	}

	public void addCoins(int value){
		coins += value;
		while (coins >= maxCoins)
			ApplyModularity ();
		updateCoinCounter ();
	}

	private void ApplyModularity(){
		coins -= maxCoins;
		GameObject.Find ("LivesCounter").GetComponent<LivesCounterScript> ().addLife ();
	}


	/*ApplyModularity() function after the modification in There's more... part
	private void ApplyModularity(){
		coins -= maxCoins;
		if (!GameObject.Find ("LivesCounter").GetComponent<LivesCounterScript> ().addLife ())
			GameObject.Find ("ScoreCounter").GetComponent<ScoreCounterScript> ().addPoints (230);
	}
	*/


	private void updateCoinCounter(){
		uiText.text = coins.ToString();
	}

	//There's more
	public void removeCoins(int value){
		coins -= value;
		if (coins < 0)
			coins = 0;
		updateCoinCounter ();
	}
}
