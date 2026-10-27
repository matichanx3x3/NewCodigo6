using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasladarPj : MonoBehaviour {

    public bool primerPiso;
    public Transform bajar;
    public Transform subir;

    // Use this for initialization
    void Start()
    {
        primerPiso = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            if (primerPiso == false)
            {
                obj.transform.position = subir.position;
                primerPiso = true;
            }
            else
            {
                if (primerPiso == true)
                {
                    obj.transform.position = bajar.position;
                    primerPiso = false;
                }
            }
        }
    }
    /*private void Update()
    {
        MoveTowardsTarget();
    }
    private void MoveTowardsTarget()
    {
        //the speed, in units per second, we want to move towards the target
        float speed = 1;
        //move towards the center of the world (or where ever you like)
        Vector3 targetPosition = new Vector3(0, 0, 0);

        Vector3 currentPosition = this.transform.position;
        //first, check to see if we're close enough to the target
        if (Vector3.Distance(currentPosition, targetPosition) > .1f)
        {
            Vector3 directionOfTravel = targetPosition - currentPosition;
            //now normalize the direction, since we only want the direction information
            directionOfTravel.Normalize();
            //scale the movement on each axis by the directionOfTravel vector components

            this.transform.Translate(
                (directionOfTravel.x * speed * Time.deltaTime),
                (directionOfTravel.y * speed * Time.deltaTime),
                (directionOfTravel.z * speed * Time.deltaTime),
                Space.World);
        }
    }*/

}
