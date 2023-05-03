using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
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
        ani.speed = 4;
        float val_x = Input.GetAxis("Horizontal");

        if (val_x > 0)
        {
            ani.SetInteger("Direction", (int)MoveDirection.RIGHT);
        }

        else
        {
            ani.speed = 0;
        }

        transform.position += new Vector3(val_x, 0).normalized * Time.deltaTime;
    }


    public enum MoveDirection
    {

        NONE = 0,
        RIGHT = 4,
    }

}
