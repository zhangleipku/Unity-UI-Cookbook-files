using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DragElementScript : MonoBehaviour {

	private GameObject temp;
	public GameObject original;
	public RectTransform dropPanel;
	
	public void OnDrag(){
		temp.transform.position = Input.mousePosition;
	}
	
	public void onDragBegins(){
		temp = (GameObject) GameObject.Instantiate (original, this.transform.position, Quaternion.identity);
		temp.transform.SetParent (GameObject.Find ("Canvas").transform);
	}

	public void onDragEnd(){
		Vector3[] worldCorners = new Vector3[4];
		dropPanel.GetWorldCorners(worldCorners);
		
		if(Input.mousePosition.x >= worldCorners[0].x && Input.mousePosition.x < worldCorners[2].x 
		   && Input.mousePosition.y >= worldCorners[0].y && Input.mousePosition.y < worldCorners[2].y) {
			Debug.Log ("Dropped");
		}

		GameObject.Destroy (temp);
	}
}
