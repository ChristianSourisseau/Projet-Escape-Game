using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{

    Direction currentDir;
    Vector2 input;
    bool isMoving = false;
    Vector3 startPos;
    Vector3 endPos;
    float t;

    public Sprite northSprite;
    public Sprite eastSprite;
    public Sprite southSprite;
    public Sprite westSprite;

    public float walkSpeed = 3f;

    public bool isAllowedToMove = true;

    void Start()
    {
        isAllowedToMove = true;
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

            if (input != Vector2.zero)
            {

                if (input.x < 0)
                {
                    currentDir = Direction.West;
                }
                if (input.x > 0)
                {
                    currentDir = Direction.East;
                }
                if (input.y < 0)
                {
                    currentDir = Direction.South;                
                }
                if (input.y > 0)
                {
                    currentDir = Direction.North;
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

                StartCoroutine(Moves(transform, ""));
            }

        }

    }

    public IEnumerator Moves(Transform entity, string dir)
    {
        isMoving = true;
        startPos = entity.position;
        t = 0;

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
        }


        while (t < 1f)
        {
            t += Time.deltaTime * walkSpeed;
            entity.position = Vector3.Lerp(startPos, endPos, t);
            yield return null;
        }

        isMoving = false;
        yield return 0;
    
    }
    public void Go(string dir)
    {
        StartCoroutine(Moves(transform, dir));
    }
}


enum Direction
{
    North,
    East,
    South,
    West
}

