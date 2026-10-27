using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class puerta : MonoBehaviour {

	public GameObject civil1,civil2,imagenCiv1,imagenCiv2,barra1,barra2,indicador;
	public Sprite imasalvo1,imasalvo2;
	Image images1,images2;
	public int nextLevel;
	// Use this for initialization
	void Start () {
		images1 = imagenCiv1.GetComponentInChildren<Image> ();
		images2 = imagenCiv2.GetComponentInChildren<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			if (!civil1.activeInHierarchy) {
				barra1.SetActive (false);
				images1.sprite = imasalvo1;
				indicador.SetActive (false);

			}
			if (!civil2.activeInHierarchy) {
				barra2.SetActive (false);
				images2.sprite = imasalvo2;
				indicador.SetActive (false);
			}

			if ((!civil1.activeInHierarchy) && (!civil2.activeInHierarchy)){
				Debug.Log("Ganaste");
				SceneManager.LoadScene(nextLevel);
			}
		}
	}
}
