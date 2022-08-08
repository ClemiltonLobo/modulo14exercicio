using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigbody;
    public Vector2 velocity;

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            myRigbody.MovePosition(myRigbody.position - velocity * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
            myRigbody.MovePosition(myRigbody.position + velocity * Time.deltaTime);
    }
}
