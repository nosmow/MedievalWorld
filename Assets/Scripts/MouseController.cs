using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    Canvas canvas;

    void Start()
    {
        canvas = FindObjectOfType<Canvas>();

        if (canvas.enabled == true )
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
