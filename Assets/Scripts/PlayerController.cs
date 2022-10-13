using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float horizontalVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
        }
    }

    void FixedUpdate()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(
            horizontalVelocity * Time.deltaTime,
            this.GetComponent<Rigidbody>().velocity.y,
            this.GetComponent<Rigidbody>().velocity.z);
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.GetComponent<ObstacleController>() != null)
        {
            GameObject.Destroy(this.gameObject);
        } 
    }
}
