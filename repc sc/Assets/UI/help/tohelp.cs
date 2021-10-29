using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tohelp : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string help)
    {
        SceneManager.LoadScene(help);
    }

    // Update is called once per frame
    void Update()
    {

    }
}