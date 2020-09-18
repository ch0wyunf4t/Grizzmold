using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroEnd : MonoBehaviour
{
    [SerializeField]
    public float timer = 15f;
    [SerializeField]
    private string sceneToLoad;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {

            SceneManager.LoadScene(sceneToLoad);
        }
    }

}