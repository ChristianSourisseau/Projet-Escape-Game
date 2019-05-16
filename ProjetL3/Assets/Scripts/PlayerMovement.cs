using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //------------------MOVEMENT USING QWERTY KEYBOARD--------------------
    
    public float speed;
    private Rigidbody2D myRigidBody;
    private Vector3 change;

    // Start is called before the first frame update
    void Start() => myRigidBody = GetComponent<Rigidbody2D>();

    // Update is called once per frame
    private void Update()
    {
        change = Vector3.zero;
        //GetAxisRaw for constant speed in stead of startup. (GetAxis)
         change.x = Input.GetAxisRaw("Horizontal");
         change.y = Input.GetAxisRaw("Vertical");
         if(change != Vector3.zero) {
            MoveCharacter();
         }

    }


 //moving a small amount each frame
 void MoveCharacter()
 {
     myRigidBody.MovePosition(
         transform.position + change * speed * Time.deltaTime);
 }
    //-----------------------------------------------------------------------


}
