using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallDestruction : MonoBehaviour {

    AudioSource m_MyAudioSource;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (StateBombe.posx > 650) {
			Debug.Log ("state =====" + StateBombe.posx);
            m_MyAudioSource = GetComponent<AudioSource>();
            m_MyAudioSource.Play();

            SceneManager.LoadScene("Victory");
        }
	}
}
