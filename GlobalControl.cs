using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;
    public float x;
    public float y;
    public float z;
    void Awake()
    {
       if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }

       else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void SavePlayer()
    {
        GlobalControl.Instance.x = x;
        GlobalControl.Instance.y = y;
        GlobalControl.Instance.z = z;
    }

    private void Start()
    {
        x = GlobalControl.Instance.x;
        y = GlobalControl.Instance.y;
        z = GlobalControl.Instance.z;
    }
}
