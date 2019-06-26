using UnityEngine;
using System.Collections;


public class Move : MonoBehaviour
{

    Direction currentDir;
    Vector3 input;
    bool isMoving = false;
    Vector3 startPos;
    Vector3 endPos;
    float t;
    
    public Sprite northSprite;
    public Sprite eastSprite;
    public Sprite southSprite;
    public Sprite westSprite;

    private Rigidbody2D myRigidBody;

    public bool canMove;

    public float walkSpeed = 3f;

    public bool isAllowedToMove = true;

    private Animator anim;
 
    void Start()
    {
        isAllowedToMove = true;
        anim = GetComponent<Animator>();
        canMove = true;
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isMoving && isAllowedToMove)
        {
            input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if (Mathf.Abs(input.x) > Mathf.Abs(input.y))
                input.y = 0;
            else
                input.x = 0;

            if (input != Vector3.zero)
            {

                if (input.x < 0)
                {
                    currentDir = Direction.West;

                    gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.01f, 0f);
                    gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 0.7f);

                    anim.SetBool("moveWest", true);

                    anim.SetBool("moveNorth", false);
                    anim.SetBool("moveSouth", false);
                    anim.SetBool("moveEast", false);
                }
                if (input.x > 0)
                {
                    currentDir = Direction.East;

                    gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.01f, 0f);
                    gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 0.7f);

                    anim.SetBool("moveEast", true);

                    anim.SetBool("moveNorth", false);
                    anim.SetBool("moveSouth", false);
                    anim.SetBool("moveWest", false);
                }
                if (input.y < 0)
                {
                    currentDir = Direction.South;

                    gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0f, -0.01f);
                    gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0.7f, 1f);

                    anim.SetBool("moveSouth", true);

                    anim.SetBool("moveNorth", false);
                    anim.SetBool("moveWest", false);
                    anim.SetBool("moveEast", false);
                }
                if (input.y > 0)
                {
                    currentDir = Direction.North;

                    gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.01f, 0.01f);
                    gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0.7f, 1f);

                    anim.SetBool("moveNorth", true);

                    anim.SetBool("moveSouth", false);
                    anim.SetBool("moveWest", false);
                    anim.SetBool("moveEast", false);
                }



                switch (currentDir)
                {
                    case Direction.North:
                        gameObject.GetComponent<SpriteRenderer>().sprite = northSprite;
                        break;
                    case Direction.East:
                        gameObject.GetComponent<SpriteRenderer>().sprite = eastSprite;
                        break;
                    case Direction.South:
                        gameObject.GetComponent<SpriteRenderer>().sprite = southSprite;
                        break;
                    case Direction.West:
                        gameObject.GetComponent<SpriteRenderer>().sprite = westSprite;
                        break;
                }

                if (Input.GetKeyDown(KeyCode.LeftControl)) { canMove = true; }
                if (canMove)
                {
                    anim.SetBool("isMoving", true);
                    //StartCoroutine(Moves(transform, ""));
                    Moves();
                }

            }
            else
            {
                if (Mathf.Abs(Input.GetAxis("Horizontal")) <= 0 || Mathf.Abs(Input.GetAxis("Verstical")) <= 0)
                {
                   anim.SetBool("isMoving", false);
                }

                anim.SetBool("moveNorth", false);
                anim.SetBool("moveSouth", false);
                anim.SetBool("moveWest", false);
                anim.SetBool("moveEast", false);
            }

        } 
    }
   
        
    /*
    private void OnTriggerStay2D(Collider2D collision)
     {
        if(collision.tag == "Wall")
        {
            canMove = false;
        }
         
     }

     private void OnTriggerExit2D(Collider2D collision)
     {
        if (collision.tag == "Wall")
        {
            canMove = true;
        }
    }*/
    
    public /*IEnumerator*/void Moves(/*Transform entity, string dir*/)
    {
        isMoving = true;
        //startPos = entity.position;
       // t = 0;
        /*
        switch (dir)
        {
            case "Up":
                endPos = new Vector3(startPos.x, startPos.y + 1, startPos.z);
                break;
            case "Down":
                endPos = new Vector3(startPos.x, startPos.y - 1, startPos.z);
                break;
            case "Left":
                endPos = new Vector3(startPos.x - 1, startPos.y, startPos.z);
                break;
            case "Right":
                endPos = new Vector3(startPos.x + 1, startPos.y, startPos.z);
                break;
            default: 
                endPos = new Vector3(startPos.x + System.Math.Sign(input.x), startPos.y + System.Math.Sign(input.y), startPos.z);
                break;
        }*/


        //while (t < 1f)
       // {
            /* t += Time.deltaTime * walkSpeed;
             entity.position = Vector3.Lerp(startPos, endPos, t);
             yield return null;*/
            myRigidBody.MovePosition(
            transform.position + input * walkSpeed * Time.deltaTime);
       // }

        isMoving = false;
       // yield return 0;
    
    }    
}


enum Direction
{
    North,
    East,
    South,
    West
}

