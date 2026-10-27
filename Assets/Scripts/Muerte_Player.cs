using UnityEngine;
using System.Collections;

public class Muerte_Player : MonoBehaviour {


	public GameObject gameOver;
	// Use this for initialization
	void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D muerte)
    {
        if (muerte.gameObject.tag == "muerte")
        {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			gameObject.GetComponent<player> ().enabled = false;
			gameOver.SetActive (true);
			Time.timeScale = 0;
            
        }
    }
}
