﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRez : MonoBehaviour
{
    void Start()
    {
        // Switch to 640 x 480 full-screen
        Screen.SetResolution(1280, 720, false);
    }
}
