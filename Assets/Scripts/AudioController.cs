using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

	private AudioSource townAudio;
	private AudioSource audienceAudio;
	private AudioSource birdAudio;

	// Use this for initialization
	void Start () {
		AudioSource[] audios = GetComponents<AudioSource> ();
		townAudio = audios [0];
		birdAudio = audios [1];
		audienceAudio = audios [2];


		foreach (AudioSource audio in audios)
			audio.Stop();


		townAudio.Play ();
		birdAudio.Play ();
		audienceAudio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
