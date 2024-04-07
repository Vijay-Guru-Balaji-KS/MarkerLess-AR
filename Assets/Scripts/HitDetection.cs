using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HitDetection : MonoBehaviour
{
    /*public UnityEvent setpositions;

    private void Start()
    {
        setpositions.AddListener(GameObject.FindGameObjectWithTag("Cube").GetComponent<ObjectPlacement>().SetHitPosition());
    }*/
    ObjectPlacement ObjectPlacement;
    private void Start()
    {
        ObjectPlacement = GetComponent<ObjectPlacement>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Surface"))
        {
            // Store the hit position using the ObjectPlacement script
            ObjectPlacement.SetHitPosition(transform.position);
        }
    }
}
