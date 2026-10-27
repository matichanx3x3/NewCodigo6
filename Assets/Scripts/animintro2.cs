using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animintro2 : MonoBehaviour {

    void Start()
    {
        //Cursor.visible = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(2);
    }
}
