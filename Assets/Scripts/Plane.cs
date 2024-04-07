using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject tracker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.CompareTag("Cube"))
        {
            GameObject obj = collision.gameObject;

            tracker.transform.position = obj.transform.position;
            Debug.Log("Got Hit by a "+obj.gameObject.name);
            Debug.Log(tracker.transform.position.x+"->"+transform.transform.position.y+"->"+tracker.transform.position.z);
        }
    }
}
