using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour {

    public static Vector3 playerPos;
    public bool boxSpawned = false;
    public GameObject playerBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            SpawnBox();
        }
    }

    void SpawnBox()
    {
        playerPos = transform.position;

        Instantiate(playerBox, transform.position, Quaternion.identity);
    }
}
