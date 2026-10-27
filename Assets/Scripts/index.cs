using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class index : MonoBehaviour {

    public GameObject PauseUI;
    private bool paused = false;

  
    void Start()
    {


        Cursor.visible = false;
        PauseUI.SetActive(false);
      
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
            
        }
        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;

        }
        if(!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
            

        }

    }

    public void Resume()
    {
        paused = false;
        Cursor.visible = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

}
