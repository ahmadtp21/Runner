using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    public PlayerController player;
    public Camera gameCamera;
    public GameObject[] blockPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        GameObject blockObject = GameObject.Instantiate<GameObject>(blockPrefabs[0]);
        blockObject.transform.SetParent(this.transform);
        blockObject.transform.position = new Vector3(0, 0, 0);

        GameObject blockObject2 = GameObject.Instantiate<GameObject>(blockPrefabs[0]);
        blockObject2.transform.SetParent(this.transform);
        blockObject2.transform.position = new Vector3(blockObject.GetComponent<BlockController>().size, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            gameCamera.transform.position = new Vector3(
                player.transform.position.x,
                gameCamera.transform.position.y,
                gameCamera.transform.position.z); 
        }
    }
}
