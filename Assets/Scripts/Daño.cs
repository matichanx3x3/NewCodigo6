using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour {

    Caracteristicas Stats;
	// Use this for initialization
	void Start () {
        Stats = GameObject.FindGameObjectWithTag("Player").GetComponent<Caracteristicas>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Stats.vida -= 10;           

            if (Stats.vida < 0)
            {
                Stats.vida = 0;
                Application.LoadLevel(Application.loadedLevel);
            }
        }

    }
}
