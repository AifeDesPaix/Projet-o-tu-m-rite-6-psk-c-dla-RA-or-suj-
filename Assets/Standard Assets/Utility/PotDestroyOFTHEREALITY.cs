using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class PotDestroyOFTHEREALITY : MonoBehaviour {

    // private AudioClip bombSong;
    AudioSource m_MyAudioSource;
	public GameObject pot;

    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {

	}
		
	void OnMouseDown() {
        Debug.Log("aaa : ");
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
		Destroy (pot, 2);
    }
}
