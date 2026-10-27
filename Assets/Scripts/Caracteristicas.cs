using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracteristicas : MonoBehaviour {

    public int vida;
    public int resistencia;
    public float velocidad;
    public int oxigeno;
    public int vision;
    public int stamina;

    // Use this for initialization
    void Start () {
        DarCaracteristicas();
	}

    void DarCaracteristicas()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            vida = 75;
            resistencia = 1;
            velocidad = 0.6f;
            oxigeno = 20;
            vision = 4;
            stamina = 20;
        }
    }
}
