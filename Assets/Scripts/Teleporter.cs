using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject pointpos;
    PlayerController playerController;
    Spawner spawner;
    BoxColliding boxColliding;
    ObjectPlacement ObjectPlacement;

    public Plane plane;

    GameObject instanceobj;
    
    // Start is called before the first frame update
    void Start()
    {
        //playerController = gameObject.GetComponent<PlayerController>();
        //spawner = GetComponent<Spawner>();

        instanceobj = GameObject.Find("Cube");

       

        playerController = GetComponent<PlayerController>(); // Change this line
        spawner = FindObjectOfType<Spawner>(); // Change this line
        //boxColliding = GetComponentInChildren<BoxColliding>();

        //ObjectPlacement = GetComponent<ObjectPlacement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //StartCoroutine("TeleportPlayer");
            StartCoroutine(TeleportPlayer()); // Change this line
        }
    }

    IEnumerator TeleportPlayer()
    {
        playerController.disabled = true;
        yield return new WaitForSeconds(1);
        //gameObject.transform.position = pointpos.transform.position;

        Debug.Log("Just checking plane");

        gameObject.transform.position = plane.tracker.transform.position;

        Debug.Log("Just checking plane "+plane.tracker.transform.position.x+" "+plane.tracker.transform.position.y+" "+plane.tracker.transform.position.z);
        yield return new WaitForSeconds(1);
        playerController.disabled = false;

        //gameObject.transform.position = spawner.getCurrentPos();
        // gameObject.transform.position = boxColliding.GetCurrentPos(); // Change this line
        //StartCoroutine(fromBoxCollidng());

        /*Vector3 contact = ObjectPlacement.GetHitPosition();
        Debug.Log("Teleporter Script la "+contact.x+" "+contact.y+" "+contact.z);
        yield return new WaitForSeconds(1);
        playerController.disabled = false;*/
    }

    /*IEnumerator fromBoxCollidng()
    {
        yield return new WaitForSeconds(1);
        gameObject.transform.position = boxColliding.GetCurrentPos();
        boxColliding.enabled = false;
        yield return new WaitForSeconds(1);
        boxColliding.enabled = true;
    }*/

    /*IEnumerator fromBoxCollidng()
    {
        if (boxColliding != null)
        {
            yield return new WaitForSeconds(1);
            //gameObject.transform.position = boxColliding.GetCurrentPos();
            gameObject.transform.position = ObjectPlacement.GetHitPosition();
            boxColliding.enabled = false;
            yield return new WaitForSeconds(1);
            boxColliding.enabled = true;
        }
        else
        {
            Debug.LogWarning("boxColliding is null");
        }
    }*/
}
