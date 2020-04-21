using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenObj : MonoBehaviour
{



    void OnTriggerEnter(Collider other)
    {

        GameObject.FindGameObjectsWithTag("Structure");
        
            

        Vector3 randScale = new Vector3(Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f));
        transform.localScale = randScale;



        


    }
    
}
