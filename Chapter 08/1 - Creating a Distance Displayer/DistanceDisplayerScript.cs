using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DistanceDisplayerScript : MonoBehaviour {

	private Image img;
	private Text txt;

	public Transform player;
	public Transform target;

	public Color firstColor;
	public Color secondColor;

	public float farthestDistance;

	public AudioClip beep;

	public float updateTime = 0.8f;

	void Start () {
		img = GetComponent<Image> ();
		txt = GetComponentInChildren<Text>();
		StartCoroutine (updateDistanceDysplayer ());
	}
	
	void Update () {
		//Normal Update
		/*float distance = Vector3.Distance (player.position, target.position);
		txt.text = distance.ToString ("F2");
		img.color = Color.Lerp (firstColor, secondColor, 1 - (distance / farestDistance));*/
	}

	//After have applied all the There's more sections
	public Transform[] targets;

	IEnumerator updateDistanceDysplayer(){
		float limiter=0;
		while (true) {
			float distance = float.MaxValue;
			foreach(Transform t in targets){
				if (distance > Vector3.Distance (player.position, t.position)){
					distance = Vector3.Distance (player.position, t.position);
				}
			}
			txt.text = distance.ToString ("F2");
			img.color = Color.Lerp (firstColor, secondColor, 1 - (distance / farthestDistance));
			if(limiter > 0.1f){
				AudioSource.PlayClipAtPoint (beep, Input.mousePosition);
				limiter=0;
			}
			yield return new WaitForSeconds(Mathf.Clamp01(distance/farthestDistance));
			limiter += Mathf.Clamp01(distance/farthestDistance);

		}
	}
	
}
