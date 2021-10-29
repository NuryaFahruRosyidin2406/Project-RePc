using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tostage1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string stage1)
    {
        SceneManager.LoadScene(stage1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
