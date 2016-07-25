using UnityEngine;
using System.Collections;

public class SubtitleShowerTesterScript : MonoBehaviour {

	public string line1, line2, line3;
	public AudioClip clip;
	public float duration;
	
	void Start () {
		StartCoroutine (test ());
	}

	IEnumerator test () {
		yield return StartCoroutine(SubtitleShowerScript.show(line1));
		yield return StartCoroutine(SubtitleShowerScript.show(line2,duration));
		yield return StartCoroutine(SubtitleShowerScript.show(line3, 0f, clip));
	}
}
