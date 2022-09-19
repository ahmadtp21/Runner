using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.CompareTag ("Obstacle") && !Data.isGameOver)
		{
        	Data.score++;
		}
    }
}
