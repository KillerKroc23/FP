using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ani.speed = 1;
        float val_x = Input.GetAxis("Horizontal");

    
        // if val_x is less than 0, then set direction to 3
        if (val_x > 0)
        {
            ani.SetInteger("Direction", (int)MoveDirection.RIGHT);
        }
        else if (val_x < 1)
        {
            ani.SetInteger("Direction", (int)MoveDirection.LEFT);
        }
        else
        {
            ani.speed = 0;
        }

        transform.position += new Vector3(val_x, 0).normalized * Time.deltaTime;

        // do this for all the directions
        // Then move the guy just like you did for animation 1.


    }

    public enum MoveDirection
    {
        NONE = 0,
        LEFT = 1,
        RIGHT = 2,
    }


}
