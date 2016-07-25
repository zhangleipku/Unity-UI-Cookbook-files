using UnityEngine;
using System.Collections;

public class MP3PlayerScript : MonoBehaviour {

	private AudioSource audioSource;

	public AudioClip[] musicList;
	private int index=0;

	private bool isStopByPlayer;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!audioSource.isPlaying && !isStopByPlayer)
			next ();
		Debug.Log (audioSource.clip.name);
	}

	public void Play(){
			audioSource.Play ();
			isStopByPlayer = false;
	}

	public void Pause(){
		audioSource.Pause ();
		isStopByPlayer = true;
	}


	public void Stop(){
		audioSource.Stop ();
		isStopByPlayer = true;
	}

	public void next(){
		index++;
		if (index == musicList.Length)
			index = 0;
		audioSource.clip = musicList [index];
		Play ();
	}

	public void previous(){
		index--;
		if (index == -1)
			index = musicList.Length-1;
		audioSource.clip = musicList [index];
		Play ();
	}



}
