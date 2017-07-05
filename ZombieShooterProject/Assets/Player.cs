using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints;
    private Transform[] spawnPointsArray;
    public bool respawnBool = false;
    private bool lastToggle = false;

	// Use this for initialization
	void Start () {
        spawnPointsArray = playerSpawnPoints.GetComponentsInChildren<Transform>();


    }
	
	// Update is called once per frame
	void Update () {
        if(lastToggle != respawnBool)
        {
            Respawn();
            respawnBool = false;
        }
        else
        {
            lastToggle = respawnBool;
        }
		
	}

    private void Respawn()
    {
        int i = Random.Range(1, spawnPointsArray.Length);
        transform.position = spawnPointsArray[i].transform.position;

    }
}
