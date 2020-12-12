using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour {

    public static Vector3 playerPos;
    public bool boxSpawned = false;
    public GameObject playerBox;
    public float playerFacing = 1f;

    // Vectors adjusting the position the box is spawned
    public Vector3 rightShift = new Vector3(3, 0);
    public Vector3 leftShift = new Vector3(-3, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tempFacing;

        if((tempFacing = Input.GetAxisRaw("Horizontal")) != 0)
        {
            playerFacing = tempFacing;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            SpawnBox();
        }
    }

    void SpawnBox()
    {
        playerPos = transform.position;
        if(playerFacing > 0)
        {
            Instantiate(playerBox, playerPos + rightShift, Quaternion.identity);
        }
        else if(playerFacing < 0)
        {
            Instantiate(playerBox, playerPos + leftShift, Quaternion.identity);
        }
            
    }
}
