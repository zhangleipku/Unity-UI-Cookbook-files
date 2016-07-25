using UnityEngine;
using System.Collections;

public class WarningScript : MonoBehaviour {

	private Animator animator;

	public Transform player;
	public float activationDistance;

	public string appearingAnimation;
	public string disappearingAnimation;

	private bool isEnable;

	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	void Update () {
		if (Vector3.Distance (player.position, transform.position) < activationDistance) {
			if(!isEnable){
				isEnable = true;
				animator.Play(appearingAnimation);
			}
		} else {
			if(isEnable){
				isEnable = false;
				animator.Play(disappearingAnimation);
			}
		}
		/*THERE'S MORE SECTION
		transform.LookAt (player.position);
		*/
	}
}
