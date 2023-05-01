using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    Animator ani;
<<<<<<< HEAD:Assets/Charset/Move.cs
    //bool isIdle = true;
=======
>>>>>>> 0eb16c64e10aefb0940cfe4248eb2b18d0280c5a:Assets/Moving.cs

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:Assets/Charset/Move.cs
        ani.speed = 2;
=======
        ani.speed = 1;
>>>>>>> 0eb16c64e10aefb0940cfe4248eb2b18d0280c5a:Assets/Moving.cs
        float val_x = Input.GetAxis("Horizontal");

    
        // if val_x is less than 0, then set direction to 3
        if (val_x > 0)
        {
            ani.SetBool("isIdle", false);

            ani.SetInteger("Direction", (int)MoveDirection.RIGHT);
        }
<<<<<<< HEAD:Assets/Charset/Move.cs

        //else if(Input.GetButtonDown("Jump") && !isJumping)
        //{
        //    ani.SetBool("isIdle", false);
        //    // Set the jumping flag to true

        //    // Trigger the Jump animation
        //}

=======
        else if (val_x < 1)
        {
            ani.SetInteger("Direction", (int)MoveDirection.LEFT);
        }
>>>>>>> 0eb16c64e10aefb0940cfe4248eb2b18d0280c5a:Assets/Moving.cs
        else
        {
            ani.SetBool("isIdle", true);

            ani.speed = 0;
        }

        transform.position += new Vector3(val_x, 0).normalized * Time.deltaTime;

        // do this for all the directions
        // Then move the guy just like you did for animation 1.


    }

    public enum MoveDirection
    {
        NONE = 0,
<<<<<<< HEAD:Assets/Charset/Move.cs
        RIGHT = 2,
    }

    //public void OnJumpAnimationEnd()
    //{
    //    // Set the jumping flag to false
    //    isJumping = false;
    //}


=======
        LEFT = 1,
        RIGHT = 2,
    }

>>>>>>> 0eb16c64e10aefb0940cfe4248eb2b18d0280c5a:Assets/Moving.cs

}
