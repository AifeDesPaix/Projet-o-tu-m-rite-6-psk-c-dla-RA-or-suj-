using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToScene2 ()
    {
    
        SceneManager.LoadScene("Level2");
    }

    public void GoToScene3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void GoToSceneVictory()
    {
        if(State.Level1 && State.Level2 && State.Level3)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
