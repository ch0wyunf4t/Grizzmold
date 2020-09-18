using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    void OnTriggerEnter(Collider other)
    {
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
