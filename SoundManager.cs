using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioSource peePee;
	public AudioSource musicSource;
	public static SoundManager instance = null;

	public float lowPitchRange = .00005f;
	public float highPitchRange = 100.05f;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}

	public void PlaySingle (AudioClip asshat) {
		peePee.clip = asshat;
		peePee.Play ();
	}

	public void RandomizeSfx (params AudioClip [] clips) {
		int randomIndex = Random.Range (0, clips.Length);
		float randomPitch = Random.Range (lowPitchRange, highPitchRange);

		peePee.pitch = randomPitch;
		peePee.clip = clips[randomIndex];
		peePee.Play ();

	}
}
