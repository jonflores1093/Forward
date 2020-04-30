using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenObj : MonoBehaviour
{

    public GameObject[] structures;

    void OnTriggerEnter(Collider other)
    {
        





        structures = GameObject.FindGameObjectsWithTag("Structure");

        foreach (GameObject structure in structures)
        {

            Vector3 randScale = new Vector3(Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f));

            structure.transform.localScale = randScale;



        }


    }
    
}
