using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosVida : MonoBehaviour {

    public int VidaFuego;
    public int GolpesRoca;
    public int GolpesPuerta;
	// Use this for initialization
	void Start () {
        EstablecerCaracteristicas();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void EstablecerCaracteristicas()
    {

        if (GameObject.FindGameObjectWithTag("Fuego"))
        {
            VidaFuego = 3;
        }

        if (GameObject.FindGameObjectWithTag("Roca"))
        {
            GolpesRoca = 2;
        }

        if (GameObject.FindGameObjectWithTag("Puerta"))
        {
            GolpesPuerta = 3;
        }

    }
}
