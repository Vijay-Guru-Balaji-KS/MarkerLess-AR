using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliding : MonoBehaviour
{


    Vector3 currentpos = Vector3.zero;


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Box collided");

        if (collision.gameObject.CompareTag("Surface"))
        {
            //Debug.Log("Collided");
            //currentpos = collision.contacts[0].point;
            currentpos = collision.contacts[0].point; // Change this line
            Debug.Log(currentpos.x+" "+currentpos.y+" "+currentpos.z);
            //Destroy(cubeprefab, 2f);
        }
    }

    public Vector3 GetCurrentPos()
    {
        return currentpos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Surface"))
            Debug.Log("Kabbam");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
