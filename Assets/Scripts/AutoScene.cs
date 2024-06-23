using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoScene : MonoBehaviour
{
    public string sceneName;
    public float timer = 3f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0 )
        {
            if (sceneName == "Menu")
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            SceneManager.LoadScene(sceneName);
        }
    }
}
