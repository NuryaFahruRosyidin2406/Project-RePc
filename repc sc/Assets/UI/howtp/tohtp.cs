﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tohtp : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string htp)
    {
        SceneManager.LoadScene(htp);
    }

    // Update is called once per frame
    void Update()
    {

    }
}