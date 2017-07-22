using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private bool heliCalled = false;
   // public AudioClip callSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("CallHeli") && !heliCalled)
        {
            heliCalled = true;
            print("Heli Called");
        }
    

    }
}
