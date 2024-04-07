using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacement : MonoBehaviour
{
    public GameObject objectPrefab; // Assign your prefab in the Unity Editor
    Spawner spawner;
    private static Vector3 hitPosition; // Static variable to store hit position

    private void Awake()
    {
        spawner = GetComponent<Spawner>();
    }

    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Q))
        {
            // Instantiate the object
            GameObject instantiatedObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);
        }*/
    }

    public void SetHitPosition(Vector3 position)
    {
        hitPosition = position;
    }

    public Vector3 GetHitPosition()
    {
        return hitPosition;
    }
}
