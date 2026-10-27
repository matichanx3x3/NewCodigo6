using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioJuego : MonoBehaviour {

    public int Iniciar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Empezar()
    {
        SceneManager.LoadScene(Iniciar);

    }

    public void Salir()
    {
        Application.Quit();
    }
}
