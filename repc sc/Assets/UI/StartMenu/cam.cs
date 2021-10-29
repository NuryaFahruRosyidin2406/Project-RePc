using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cam : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string camanim)
    {
        SceneManager.LoadScene(camanim);
    }

    // Update is called once per frame
    void Update()
    {

    }
}