using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour {

    public static Vector3 playerPos;
    public bool boxSpawned = false;
    public GameObject playerBox;
    public GameObject currentBox;
    private float playerFacing = 1f;

    // Vectors adjusting the position the box is spawned
    private Vector3 rightShift = new Vector3(1.5f, 0.25f);
    private Vector3 leftShift = new Vector3(-1.5f, 0.25f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tempFacing;

        // Check the player's facing if it is a non zero value
        // Positive means right, negative means left
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
        if (playerFacing > 0)
        {
            playerPos = transform.position + rightShift;
        }
        else if (playerFacing < 0)
        {
            playerPos = transform.position + leftShift;
        }

        if (!boxSpawned) // Initially spawn the box
        {
            currentBox = Instantiate(playerBox, playerPos, Quaternion.identity);
            boxSpawned = true;        
        }
        else // Box has already spawned, need to move it to new position
        {
            //currentBox.transform.rotation = Quaternion.identity;
            //currentBox.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            //currentBox.transform.position = playerPos;

            Destroy(currentBox);
            currentBox = Instantiate(playerBox, playerPos, Quaternion.identity);
        }
    }
}
