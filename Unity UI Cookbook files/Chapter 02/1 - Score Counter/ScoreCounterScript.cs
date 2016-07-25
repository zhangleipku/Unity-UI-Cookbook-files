using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounterScript : MonoBehaviour {

	private Text uiText;

	private long score = 0;

	//There's more...
	public long getScore(){
		return score;
	}
	
	void Start () {
		uiText = this.GetComponent<Text> ();
		updateScoreCounter ();
	}
	
	public void addPoints(int points){
		score += points;
		updateScoreCounter ();
	}

	//There's more...
	public void removePoints(int points){
		score -= points;
		if (score < 0)
			score = 0;
		updateScoreCounter ();
	}

	private void updateScoreCounter(){
		uiText.text = "<color=blue>Score</color>: " + score;
	}
	
}
