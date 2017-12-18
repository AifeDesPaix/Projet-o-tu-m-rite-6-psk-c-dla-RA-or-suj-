using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour {
	public RawImage img;
	public Texture[] textures;
	static private int itemIndex;


	// Use this for initialization
	void Start () {
		itemIndex = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (State.Torche1 && State.Torche1) {
			SceneManager.LoadScene("Level2");
		}
	}

	public void Switch () {
		itemIndex++;
		img = GetComponent<Canvas> ().GetComponentInChildren<RawImage> ();
		img.texture = Resources.Load ("Items/item" + itemIndex) as Texture;

		if(itemIndex == 3) {
			itemIndex = 0;
		}
	}
}
