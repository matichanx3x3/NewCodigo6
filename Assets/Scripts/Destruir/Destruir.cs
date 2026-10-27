using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{

    Collider2D Collision;
    ObjetosVida VidObj;
    // Use this for initialization
    void Start()
    {

        VidObj = GetComponent<ObjetosVida>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D()
    {
        if (GameObject.FindGameObjectWithTag("ColTools"))
        {
            VidObj.GolpesRoca -= 1;
            if (VidObj.GolpesRoca == 0)
            {
                VidObj.GolpesRoca = 0;
                Destroy(gameObject);

            }
        }


        if (GameObject.FindGameObjectWithTag("ColTools"))
        {
            VidObj.VidaFuego -= 1;
            if (VidObj.VidaFuego == 0)
            {
                VidObj.VidaFuego = 0;
                Destroy(gameObject);
            }
        }

        if (GameObject.FindGameObjectWithTag("ColTools"))
        {
            VidObj.GolpesPuerta -= 1;
            if (VidObj.GolpesPuerta == 0)
            {
                VidObj.GolpesPuerta = 0;
                Destroy(gameObject);
            }
        }


    }


}
