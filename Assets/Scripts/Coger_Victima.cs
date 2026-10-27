using UnityEngine;
using System.Collections;

public class Coger_Victima : MonoBehaviour {

	//public GameObject indicador;
	//Animator anim;
	//GameObject cara;

	// Use this for initialization
	void Start () {
		//anim = indicador.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Civiles")
        {
            other.gameObject.SetActive (false);
            //Destroy(gameObject);
			//indicador.SetActive (true);

			//anim.SetBool ("iniAlerta", true);
			//StartCoroutine(DesactivarAnim());

        }
			
    }

	/*IEnumerator DesactivarAnim() {
		yield return new WaitForSeconds(1);
		anim.SetBool ("iniAlerta", false);
	}*/
}
