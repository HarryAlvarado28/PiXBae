using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveCode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0,0.5f,0));
        transform.Translate(new Vector2(1, 3));
	}
}
