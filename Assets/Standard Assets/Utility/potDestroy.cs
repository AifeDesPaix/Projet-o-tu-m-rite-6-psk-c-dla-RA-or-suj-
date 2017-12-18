using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class potDestroy : MonoBehaviour {



	// private AudioClip bombSong;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}
		
	void OnMouseDown() {
		if (this.name == "TorcheWrapperLeft") {
			State.Torche1 = true;
		}
		if (this.name == "TorcheWrapperLeft") {
			State.Torche2 = true;
		}
	}
}
