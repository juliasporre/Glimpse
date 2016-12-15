using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

	private AudioSource[] audios;
	private AudioSource townAudio;
	private AudioSource audienceAudio;
	private AudioSource birdAudio;

	private Vector3 cameraPos;
	private Vector3 windowPos;


	// Use this for initialization
	void Start () {
		audios = GetComponents<AudioSource> ();
		townAudio = audios [0];
		birdAudio = audios [1];
		audienceAudio = audios [2];


		foreach (AudioSource audio in audios) {
			audio.Play ();
			audio.volume = 0f;
		}

	}
	
	// Update is called once per frame
	void Update () {

		cameraPos = GameObject.Find ("Camera").transform.position;
		windowPos = GameObject.Find ("woodenframe2").transform.position;
	
		float distance = Vector3.Distance (cameraPos, windowPos);


		Debug.Log ("CameraPos : " + cameraPos);
		Debug.Log ("windowPos : " + windowPos);
		Debug.Log ("Distance: " + distance);

		if (distance < 2.75f) {
			foreach (AudioSource audio in audios) {
				audio.volume = 1f - distance / 2.75f;
			}
		}
	}
}
