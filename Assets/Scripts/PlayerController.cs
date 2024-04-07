using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool disabled = false;

    public CharacterController characterController;
    public float playerspeed = 1f;
    public Vector3 destinationPosition; // Store the destination position
    private bool canTeleport = true; // Flag to control teleporting once per press

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        destinationPosition = transform.position; // Set starting position as destination
    }

    // Update is called once per frame
    void Update()
    {
        if(!disabled)
        move();
        //move();

        /*if (Input.GetKeyDown(KeyCode.E) && canTeleport)
        {
            canTeleport = false; // Prevent multiple teleports on a single press
            Teleport();
        }

        if (!Input.GetKey(KeyCode.E))
        {
            canTeleport = true; // Allow teleporting again when the key is released
        }*/
    }

    void move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        characterController.Move(new Vector3(horizontal * playerspeed * Time.deltaTime, 0, vertical * playerspeed * Time.deltaTime));
    }

}
