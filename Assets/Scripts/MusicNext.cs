using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNext : MonoBehaviour
{
    public static MusicNext instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
