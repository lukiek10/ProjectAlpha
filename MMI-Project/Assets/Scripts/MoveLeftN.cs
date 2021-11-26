using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftN : MonoBehaviour
{
    public float speed = 10.0f;
    private float leftBound = -15;
    private PlayerControllerN playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerControllerN>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver==false){
        transform.Translate(Vector3.left * Time.deltaTime * speed);}

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);}
        }
    }

