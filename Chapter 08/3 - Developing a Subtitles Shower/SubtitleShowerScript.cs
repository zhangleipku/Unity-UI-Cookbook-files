using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubtitleShowerScript : MonoBehaviour {

	private static Text uiText;

	/*THERE'S MORE SECTION
	private static Image uiImage;
	private static Text uiName;
	*/

	const float defaultDuration = 5f;

	// Use this for initialization
	void Start () {
		uiText = GetComponentInChildren<Text> ();

		/*THERE'S MORE SECTION
		uiImage = GetComponentInChildren<Image> ();
		
		uiName = GameObject.Find("SubtitleShowerCharactername").GetComponent<Text> ();
		uiText = GameObject.Find("SubtitleShowerText").GetComponent<Text> ();
		*/


	}

	public static IEnumerator show(string subtitle, float duration = defaultDuration, AudioClip clip = null){
		uiText.text = subtitle;
		if (clip) {
			AudioSource.PlayClipAtPoint (clip, Input.mousePosition);
			yield return new WaitForSeconds (clip.length);
		} else {
			yield return new WaitForSeconds (duration);
		}
		uiText.text = "";
	}

	/* THERE'S MORE SECTION:
	public static IEnumerator show(string subtitle, float duration = defaultDuration, AudioClip clip = null, Sprite icon = null, string name = ""){
		uiName.text = name;
		uiImage.sprite = icon;
		uiText.text = subtitle;
		if (clip) {
			AudioSource.PlayClipAtPoint (clip, Input.mousePosition);
			yield return new WaitForSeconds (clip.length);
		} else {
			yield return new WaitForSeconds (duration);
		}
		uiText.text = "";
		uiImage.sprite = null;
		uiName.text = "";
	}*/
}
