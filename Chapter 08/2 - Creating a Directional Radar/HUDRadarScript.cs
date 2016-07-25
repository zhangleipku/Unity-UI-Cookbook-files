using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDRadarScript : MonoBehaviour {

	private Image arrow;

	public Transform player;
	public Transform target;
	
	void Start () {
		arrow = GetComponent<Image>();
	}
	
	void Update () {

		Vector3 playerProjection = new Vector3 (player.position.x, 0, player.position.z);
		Vector3 targetProjection = new Vector3 (target.position.x, 0, target.position.z);

		Vector3 playerDir = (new Vector3 (player.forward.x, 0, player.forward.z).normalized);
		Vector3 targetDir = (targetProjection - playerProjection).normalized;

		float angle = Mathf.Acos(Vector3.Dot (playerDir, targetDir))*Mathf.Rad2Deg;

		if (Vector3.Cross (playerDir, targetDir).y < 0){
			arrow.rectTransform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle));
		} else {
			arrow.rectTransform.rotation = Quaternion.Euler (new Vector3 (0, 0, -angle));
		}
	}

	//THERE'S MORE SECTION
	void OnDrawGizmos() {
		Gizmos.color = Color.red;
		Gizmos.DrawLine(new Vector3 (player.position.x, 0, player.position.z), new Vector3 (target.position.x, 0, target.position.z));
		Gizmos.color = Color.green;
		Gizmos.DrawRay (new Ray(new Vector3 (player.position.x, 0, player.position.z),(new Vector3 (player.forward.x, 0, player.forward.z).normalized)));
	}
}
