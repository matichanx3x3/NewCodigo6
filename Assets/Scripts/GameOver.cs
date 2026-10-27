using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

		public GameObject GameUI;
		


		void Start()
		{



			GameUI.SetActive(false);

		}


    private void Update()
    {
        if (GameUI.activeSelf == true)
        {
            Cursor.visible = true;
        }
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

