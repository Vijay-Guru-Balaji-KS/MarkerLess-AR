using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubeprefab;

    /*Vector3 currentpos = Vector3.zero;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if(collision.gameObject.CompareTag("Surface"))
        {
            Debug.Log("Collided");
            //currentpos = collision.contacts[0].point;
            /*currentpos = collision.contacts[0].point; // Change this line
            Debug.Log(currentpos.x+" "+currentpos.y+" "+currentpos.z);
            Destroy(cubeprefab, 2f);
        }
        
    }

    

    public Vector3 GetCurrentPos() 
    {
        return currentpos; 
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnCube();
    }

    public void SpawnCube()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            GameObject duplicate = Instantiate(cubeprefab,transform.position,Quaternion.identity);
        }
    }

    


    /*private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.CompareTag("Surface"))
        Debug.Log("Trigged");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name+" in stay");
    }*/
}
