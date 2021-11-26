using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerN : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25,0,0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerControllerN playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerControllerN>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver==false){
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
}
