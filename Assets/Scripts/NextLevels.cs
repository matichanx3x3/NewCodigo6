using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevels : MonoBehaviour {

    [SerializeField]
    GameObject civil1,civil2,civil3,civil4,civil5;
    public int nextLevel;
    //[SerializeField]
    //private BoxCollider2D Next;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((!civil1.activeInHierarchy) && (!civil2.activeInHierarchy) && (!civil3.activeInHierarchy) && (!civil4.activeInHierarchy) && (!civil5.activeInHierarchy))
        {
            // Next.enabled = true;
            Debug.Log("Ganaste");
            SceneManager.LoadScene(nextLevel);
        }
    }

}
