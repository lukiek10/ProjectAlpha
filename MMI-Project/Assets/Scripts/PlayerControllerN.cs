using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerN : MonoBehaviour
{
   private Rigidbody playerRb;
    public float jumpForce = 5.0f;
    public float gravityModifier=1;
    public bool isOnGround = true;
     public float horizontalInput;
     public float speed = 10.0f;
     public bool gameOver=false;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space)&&isOnGround)
        {
           playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
           isOnGround= false;
        }
    }

    private void OnCollisionEnter(Collision collision){
        //isOnGround=true;
        if(collision.gameObject.CompareTag("Ground") ){
            isOnGround=true;
        }
        else if(collision.gameObject.CompareTag("Obstacle")){
            gameOver=true;
            Debug.Log("Game Over!");
            
        }
    }
}
