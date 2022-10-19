using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour
{
    public int speed;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, 90);

        }
        else if (Input.GetKey("s"))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, 270);

        }
        else if (Input.GetKey("a"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, 0);

        }
        else if (Input.GetKey("d"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, 180);

        }
        else
        {


        }
    }

    void OnCollisionEnter(Collider other)
    {

        print("tag=" + gameObject.tag);

        if (other.gameObject.tag == "Enemy")
        {
            anim.Play("PacMan2Ddeath");
            //Destroy(this.gameObject);

        }

    }
}
