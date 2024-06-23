using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStatic : MonoBehaviour
{
    private static MusicStatic musicSingleton;

    void Start()
    {
        if (musicSingleton == null)
        {
            musicSingleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
