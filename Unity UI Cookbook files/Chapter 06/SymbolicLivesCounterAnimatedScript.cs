using UnityEngine;
using System.Collections;

public class SymbolicLivesCounterAnimatedScript : MonoBehaviour {
	
	public GameObject[] hearts;
	private int lives;

	public float speedController = 1f;

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
				hearts [i].GetComponent<Animator> ().speed = (hearts.Length - lives)*speedController;
			}else{
				hearts[i].SetActive(false);
			}
		}
		/*There's more section
		if (lives == 1) {
			hearts [0].GetComponent<Animator> ().speed = 2.5f;
		} else {
			hearts [0].GetComponent<Animator> ().speed = 1.0f;
		}*/
	}
}
