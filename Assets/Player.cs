using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Player : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;
    public float speed = 2;
    private Rigidbody rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DoMove();
    }





    void DoMove()
    {
        Vector3 velocity = rb.velocity;



        if (Input.GetKey("w"))
        {
            Vector3 v3Force = 2 * transform.forward;
            GetComponent<Rigidbody>().AddForce(v3Force);
            anim.Play("Walk");
        }
        else if (Input.GetKey("s"))
        {
            Vector3 v3Force = -2 * transform.forward;
            GetComponent<Rigidbody>().AddForce(v3Force);
            anim.Play("Walk");
        }
        else if (Input.GetKey("a"))
        {
            Vector3 v3Force = -2 * transform.right;
            GetComponent<Rigidbody>().AddForce(v3Force);
            anim.Play("Walk");
        }
        else if (Input.GetKey("d"))
        {
            Vector3 v3Force = 2 * transform.right;
            GetComponent<Rigidbody>().AddForce(v3Force);
            anim.Play("Walk");
        }
        else
        {
            Vector3 v3Force = 0 * transform.forward;
            GetComponent<Rigidbody>().AddForce(v3Force);
            anim.Play("douknodewaeidle");
        }

        /*
          if (Input.GetKey("s"))
          {
              velocity.z = -5;
          }
          if (Input.GetKey("w"))
          {
              velocity.z = 5;
          }
        */

        //   anim.SetBool("Walking", false);


        //   if (velocity.x != 0)
        //  {
        //      anim.SetBool("Walking", true);
        //   }
        //   else
        //  {
        //      anim.SetBool("Walking", false);
        //  }

        rotation.y += Input.GetAxis("Mouse X");
        //rotation.x += -Input.GetAxis("Mouse Y");
        transform.eulerAngles = (Vector2)rotation * speed;






        rb.velocity = velocity;

    }
}
