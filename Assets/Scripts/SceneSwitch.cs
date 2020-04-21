using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        Scene sceneCurrent = SceneManager.GetActiveScene();

        string sceneName = sceneCurrent.name;

        if (sceneName == "Street")
        {
            SceneManager.LoadScene("MushroomStreet");
        }

        else if (sceneName == "MushroomStreet")
        {
            SceneManager.LoadScene("DistortStreet");
        }
        else if (sceneName == "DistortStreet")
        {
            SceneManager.LoadScene("Menu");
            Cursor.lockState = CursorLockMode.None;
        }

    }
}
