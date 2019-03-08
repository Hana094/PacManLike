using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // to control the movemnt of the character
    CharacterController characterController;

    // the reference of object that contains the Player model or sprite, to rotate it 
    [SerializeField]GameObject playerBody;

    [SerializeField] float speed;

    //Set in memory a space to catch the input
    Vector3 movementDirection;

    private void Awake()
    {
        //get the reference of the Player controller
        characterController = GetComponent<CharacterController>();
    }

    // loop called once per frame
    private void Update()
    {
        //get the input and interpretate it as a vector
        /*Free movement
         movementDirection = Input.GetAxisRaw("Horizontal") * Vector3.right + Input.GetAxisRaw("Vertical") * Vector3.forward;
         */
        // restricted movement
        if (Input.GetAxisRaw("Horizontal")!=0)
        {
            movementDirection = Input.GetAxisRaw("Horizontal") * Vector3.right;
            RotateBodyReference();
        }
        else if(Input.GetAxisRaw("Vertical")!=0)
        {
            movementDirection = Input.GetAxisRaw("Vertical") * Vector3.forward;
            RotateBodyReference();

        }
        else
        {
            movementDirection = Vector3.zero;
        }
        // tell the character controller to move to the desired direction
        characterController.Move(movementDirection.normalized * Time.fixedDeltaTime * speed);
    }


    void RotateBodyReference()
    {
        playerBody.transform.LookAt(transform.position+movementDirection);
    }

    

}
