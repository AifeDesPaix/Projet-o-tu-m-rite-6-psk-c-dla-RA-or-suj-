using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandler : MonoBehaviour {

	public GameObject panel;

	// Use this for initialization
	void Start () {
	//	panel = this.panel;
	//	panel.SetActive(true);
		Destroy(panel, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator wait() {
		print (Time.time);	
		yield return new WaitForSeconds (4);
		print (Time.time);
	}
}
