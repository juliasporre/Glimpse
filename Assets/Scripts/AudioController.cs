using UnityEngine;
using System.Collections;
using Vuforia;

public class AudioController : MonoBehaviour, ITrackableEventHandler {

	private AudioSource[] audios;
	private AudioSource townAudio;
	private AudioSource audienceAudio;
	private AudioSource birdAudio;

	private Vector3 cameraPos;
	private Vector3 windowPos;

	private TrackableBehaviour mTrackableBehaviour;


	// Use this for initialization
	void Start () {
		audios = GetComponents<AudioSource> ();

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}

	}
	
	// Update is called once per frame
	void Update () {

		cameraPos = GameObject.Find ("Camera").transform.position;
		windowPos = transform.position;
	
		float distance = Vector3.Distance (cameraPos, windowPos);

		if (distance < 2.75f) {
			foreach (AudioSource audio in audios) {
				audio.volume = 1f - distance / 2.75f;
			}
		}

	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			// Play audio when target is found
			foreach (AudioSource audio in audios)
				audio.Play ();
		}
		else
		{
			// Stop audio when target is lost
			foreach (AudioSource audio in audios)
				audio.Stop();
		}
	}


}
