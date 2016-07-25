using UnityEngine;
using System.Collections;

public class DraggablePanelScript : MonoBehaviour {

	public void OnDrag(){
		transform.position = Input.mousePosition;
	} 

}
