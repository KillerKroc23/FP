using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animator ani;
    //bool isIdle = true;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ani.speed = 2;
        float val_x = Input.GetAxis("Horizontal");

        if (val_x > 0)
        {
            ani.SetBool("isIdle", false);

            ani.SetInteger("Direction", (int)MoveDirection.RIGHT);
        }

        //else if(Input.GetButtonDown("Jump") && !isJumping)
        //{
        //    ani.SetBool("isIdle", false);
        //    // Set the jumping flag to true

        //    // Trigger the Jump animation
        //}

        else
        {
            ani.SetBool("isIdle", true);

            ani.speed = 0;
        }

        transform.position += new Vector3(val_x, 0).normalized * Time.deltaTime;
    }


    public enum MoveDirection
    {
        NONE = 0,
        RIGHT = 2,
    }

    //public void OnJumpAnimationEnd()
    //{
    //    // Set the jumping flag to false
    //    isJumping = false;
    //}



}
