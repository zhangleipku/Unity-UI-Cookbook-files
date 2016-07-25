using UnityEngine;
using System.Collections;

public class FreezeTimeScript : MonoBehaviour {

 	public void setTimeScale(float timeScale){
		Time.timeScale = timeScale;
	}
}
