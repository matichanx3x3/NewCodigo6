using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    Caracteristicas Stats;
    Animator Anim;
	public bool playerMoving;
	public Vector2 lastMove;
    public bool hachaDerecha;
    public bool hachaArriba;
    public bool hachaAbajo;
    public bool hachaIzquierda;
    public bool extintorDerecha;
    public bool extintorIzquierda;
    public bool extintorArriba;
    public bool extintorAbajo;
    
    [SerializeField]
    private BoxCollider2D ToolsD;
    [SerializeField]
    private BoxCollider2D ToolsA;
    [SerializeField]
    private BoxCollider2D ToolsAb;
    [SerializeField]
    private BoxCollider2D ToolsI;



    // Use this for initialization
    void Start () {

        Stats = GameObject.FindGameObjectWithTag("Player").GetComponent<Caracteristicas>();
		Anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {


        Mover();
        Animar();
        Hacha();
        Extintor();
	}

    void Mover()
    {
        playerMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * Stats.velocidad * Time.deltaTime, 0, 0));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0, Input.GetAxisRaw("Vertical") * Stats.velocidad * Time.deltaTime, 0));
            playerMoving = true;
            lastMove = new Vector2(0, Input.GetAxisRaw("Vertical"));
        }
    }
    void Animar()
    {
        Anim.SetFloat("moveX", Input.GetAxisRaw("Horizontal"));
        Anim.SetFloat("moveY", Input.GetAxisRaw("Vertical"));
        Anim.SetBool("playerMoving", playerMoving);
        Anim.SetFloat("lastMoveX", lastMove.x);
        Anim.SetFloat("lastMoveY", lastMove.y);
    }

    void Hacha()
    {
        hachaAbajo= false;
        hachaArriba = false;
        hachaDerecha = false;
        hachaIzquierda = false;

        if(Input.GetKeyDown (KeyCode.O))
        {
            if(lastMove.x == 1)
            {
                hachaDerecha = true;
                Anim.SetTrigger("hachaDerecha");
            }
            if (lastMove.x == -1)
            {
                hachaIzquierda = true;
                Anim.SetTrigger("hachaIzquierda");
            }
            if (lastMove.y == 1)
            {
                hachaArriba = true;
                Anim.SetTrigger("hachaArriba");
            }
            if (lastMove.y == -1)
            {
                hachaAbajo = true;
                Anim.SetTrigger("hachaAbajo");
            }

        }

    }

    void Extintor()
    {
        extintorAbajo = false;
        extintorArriba = false ;
        extintorDerecha = false ;
        extintorIzquierda = false;

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (lastMove.x == 1)
            {
                extintorDerecha = true;
                Anim.SetTrigger("extintorDerecha");
            }
            if (lastMove.x == -1)
            {
                extintorIzquierda = true;
                Anim.SetTrigger("extintorIzquierda");
            }
            if (lastMove.y == 1)
            {
                extintorArriba = true;
                Anim.SetTrigger("extintorArriba");
            }
            if (lastMove.y == -1)
            {
                extintorAbajo = true;
                Anim.SetTrigger("extintorAbajo");
            }

        }

    }

    public void UsarTool()
    {
        /* ToolsD.enabled = false;
         ToolsA.enabled = false;
         ToolsI.enabled = false;
         ToolsAb.enabled = false;*/


        if (lastMove.x == 1 )
        {
            ToolsD.enabled = !ToolsD.enabled;
            ToolsA.enabled = false;
            ToolsI.enabled = false;
            ToolsAb.enabled = false;
            
            

        }
        if (lastMove.x == -1 )
        {
            ToolsI.enabled = !ToolsI.enabled;
            ToolsD.enabled = false;
            ToolsA.enabled = false;
            ToolsAb.enabled = false;
            
        }
        if (lastMove.y == 1 )
        {
            ToolsA.enabled = !ToolsA.enabled;
            ToolsD.enabled = false;
            ToolsI.enabled = false;
            ToolsAb.enabled = false;
            
        }
        if (lastMove.y == -1 )
        {
            ToolsAb.enabled = !ToolsAb.enabled;
            ToolsD.enabled = false;
            ToolsA.enabled = false;
            ToolsI.enabled = false;
            
        }

        

    }

    private void OnCollisionEnter2D()
    {
        if (GameObject.FindGameObjectWithTag("Fuego"))
        {
           

            float verticalPush = transform.position.y - transform.position.y;
            float horizontalPush = transform.position.x - transform.position.x;

            //rigidbody2D.Addforce(new Vector2(-horizontalPush , -verticalPush)*300);
            transform.Translate(new Vector2(-horizontalPush, -verticalPush)/2);
            
        }

    }





}