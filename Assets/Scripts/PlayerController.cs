using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    public GameObject gameOverPanel;
    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

        gameOverPanel.SetActive(false);
    }

    void OnCollisionStay(){
        isGrounded = true;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            Physics.gravity *= -1;
        }
    }

     private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag.Equals("Obstacle"))
        {
            gameOverPanel.SetActive(true);
            Data.isGameOver = true;
        }
    }
}
