using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LivesCounterScript : MonoBehaviour {

	private Text uiText;

	public int maxLives;
	private int lives;
	
	void Start () {
		lives = maxLives;
		uiText = this.GetComponent<Text> ();
		updateLivesCounter();
	}

	//Return true if the life is added
	public bool addLife(){
		if (lives < maxLives) {
			lives++;
			updateLivesCounter();
			return true;
		}
		return false;
	}

	//Return true if the player has no lives
	public bool loseLife(){
		lives--;
		if (lives > 0) {
			updateLivesCounter();
			return false;
		}
		lives = 0;
		updateLivesCounter();
		return true;
	}

	private void updateLivesCounter(){
		uiText.text = "<color=red>Lives</color>: " + lives;
	}

	//There's more
	public void increaseMaxLives(int value){
		maxLives += value;
	}

	//There's more
	public void decreaseMaxLives(int value){
		maxLives -= value;
		if (maxLives < 1)
			maxLives = 1;
		if (lives > maxLives)
			lives = maxLives;
	}

	//There's more
	public int getLives(){
		return lives;
	}
}
