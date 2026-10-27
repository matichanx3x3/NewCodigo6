using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class oxigeno : MonoBehaviour {
	
	public GameObject panelGameOver;
	public Image fill;
	public Sprite persoMorado, skull ;
	string minutes;
	string seconds;
	public GameObject persona,PerPrincipal; 
	Image images;

	// Use this for initialization
	void Start () {
		images = persona.GetComponentInChildren<Image> ();

	}

	// Update is called once per frame
	void Update () {	
		this.GetComponentInChildren<Slider> ().value -= 1 * Time.deltaTime;

		if (this.GetComponentInChildren<Slider> ().value < this.GetComponentInChildren<Slider> ().maxValue / 2) {
			Debug.Log ("CAMBIAR COLOR");
			fill.color = Color.red;
			images.sprite = persoMorado;
		}


		if(this.GetComponentInChildren<Slider> ().value == 0){
			Debug.Log ("END OF THE GAME");
			images.sprite = skull;
			panelGameOver.SetActive (true);
			PerPrincipal.GetComponent<player> ().enabled = false;

		}


			
	}
}
