using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour {

	float timer;

	public float pause = 2;
	public GameObject[] obstacles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > pause)
        {
            int random = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
