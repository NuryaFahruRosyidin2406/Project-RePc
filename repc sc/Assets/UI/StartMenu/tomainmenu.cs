﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tomainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string mainmenu)
    {
        SceneManager.LoadScene(mainmenu);
    }

    // Update is called once per frame
    void Update()
    {

    }
}