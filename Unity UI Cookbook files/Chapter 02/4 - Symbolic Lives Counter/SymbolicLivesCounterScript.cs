using UnityEngine;
using System.Collections;

public class SymbolicLivesCounterScript : MonoBehaviour {
	
	public GameObject[] hearts;
	private int lives;
	
	void Start () {
		lives = hearts.Length;
	}

	public bool addLife(){
		if (lives < hearts.Length) {
			lives++;
			updateSymbolicLivesCounter();
			return true;
		}
		return false;
	}

	public bool loseLife(){
		lives--;
		if (lives > 0) {
			updateSymbolicLivesCounter();
			return false;
		}
		lives = 0;
		updateSymbolicLivesCounter();
		return true;
	}

	private void updateSymbolicLivesCounter () {
		for (int i=0; i<hearts.Length; i++) {
			if(i<lives){
				hearts[i].SetActive(true);
			}else{
				hearts[i].SetActive(false);
			}
		}
	}
}
