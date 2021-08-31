using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amemation : MonoBehaviour
{
    bool canRun = true;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        canRun = new HUD().getRunning();
        //Here I am implementing movements and rotations of character. going trough all possible outcomes making it a stable code.
        //All movements are going one by one so there would be no conflict between movements.

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("IsWalking", true);
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                transform.forward = Vector3.RotateTowards(transform.forward, Vector3.forward + Vector3.left, 4 * Time.deltaTime, 0);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                transform.forward = Vector3.RotateTowards(transform.forward, Vector3.forward + Vector3.right, 4 * Time.deltaTime, 0);
            }else if (Input.GetKey(KeyCode.W))
            {
                transform.forward = Vector3.RotateTowards(transform.forward,Vector3.forward, 4 * Time.deltaTime,0);
            }
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) && canRun)
            {
                anim.SetBool("IsRunning", true);
            }
            else
            {
                anim.SetBool("IsRunning", false);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("IsWalking", true);
                if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
                {
                    transform.forward = Vector3.RotateTowards(transform.forward, Vector3.back + Vector3.left, 4 * Time.deltaTime, 0);
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    transform.forward = Vector3.RotateTowards(transform.forward, Vector3.left, 4 * Time.deltaTime, 0);
                }
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) && canRun)
                {
                    anim.SetBool("IsRunning", true);
                }
                else
                {
                    anim.SetBool("IsRunning", false);
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("IsWalking", true);
                    if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
                    {
                        transform.forward = Vector3.RotateTowards(transform.forward, Vector3.back + Vector3.right, 4 * Time.deltaTime, 0);
                    }
                    else if (Input.GetKey(KeyCode.D))
                    {
                        transform.forward = Vector3.RotateTowards(transform.forward, Vector3.right, 4 * Time.deltaTime, 0);
                    }
                    if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) && canRun)
                    {
                        anim.SetBool("IsRunning", true);
                    }
                    else
                    {
                        anim.SetBool("IsRunning", false);
                    }
                }
                else
                {
                    if (Input.GetKey(KeyCode.S))
                    {
                        anim.SetBool("IsWalking", true);
                        if (transform.rotation.y != -180)
                        {
                            transform.forward = Vector3.RotateTowards(transform.forward, Vector3.back, 4 * Time.deltaTime, 0);
                        }
                        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) && canRun)
                        {
                            anim.SetBool("IsRunning", true);
                        }
                        else
                        {
                            anim.SetBool("IsRunning", false);
                        }
                    }
                    else
                    {
                        anim.SetBool("IsWalking", false);
                        anim.SetBool("IsRunning", false);
                    }
                }
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("IsJumping", true);
        }
        else
        {
            anim.SetBool("IsJumping", false);
        }
    }
}
