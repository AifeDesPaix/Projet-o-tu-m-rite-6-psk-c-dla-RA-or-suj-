using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Excalibur : MonoBehaviour {

    AudioSource m_MyAudioSource;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseClick()
    {
        bool accessinble = true; // todo si la cage est ouverte
        if(accessinble)
        {
            m_MyAudioSource = GetComponent<AudioSource>();
            m_MyAudioSource.Play();
            wait();
            SceneManager.LoadScene("Scene3");

        }
    }
    IEnumerator wait()
    {
        print(Time.time);
        yield return new WaitForSeconds(2);
        print(Time.time);
    }
}
