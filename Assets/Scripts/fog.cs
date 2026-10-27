using UnityEngine;
using System.Collections;

public class fog : MonoBehaviour {

  	float timer;
	Color humo;
	public float densidad;

	// Use this for initialization
	void Start () {
	
		humo = this.gameObject.GetComponent<SpriteRenderer> ().color;

	}
	
	// Update is called once per frame
	void Update () {
		
		timer += densidad*Time.deltaTime; 
		this.gameObject.GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, timer);	



	}
}
