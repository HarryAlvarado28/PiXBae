using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmgr : MonoBehaviour {
   
    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void nextLevel(string level)
    {
        SceneManager.LoadScene(level);

    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Se ha salido del juego");

    }
}
