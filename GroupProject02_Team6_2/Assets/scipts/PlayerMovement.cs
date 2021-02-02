using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static bool move = false;
    private Rigidbody rb;
    [SerializeField]
    protected float movement_speed = 2;
    protected bool facingright;
    public static float direction = 0.5f;
    float turn = -1;
    public float pushBack = -250;

    public bool move_right = true;

    public string wallTag = "Wall";
    public string wall_rightTag = "Wall_right";
    public string wall_leftTag = "Wall_left";

    public string spongeTag = "Sponge";
    public string speedTag = "Speed";
    public bool speed = false;

    public string next = "left";

    public float czasSpeeda = 1.5f;
    public float wysokoscSponga = 350;


    int collsiion_counter = 0;



    public void TurnOffSpeed()
    {
        speed = false;
    }

    // Start is called before the first frame update
    public virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        facingright = true;

    }


    void OnMouseOver()
    {

       // Debug.Log("na kuleczce");

    }
    public void changeDirection()
    {
        facingright = !facingright;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        // if (move == true)
        movement(horizontal);
        //    flip(horizontal);

        if (Input.GetKey("space"))
        {
            if (move == false)
                move = true;
            else
                move = false;
        }
    }

    private void movement(float horizontal)
    {
       // Debug.Log("move w playerze: " + move);
        if (move == true)
        {
            rb.isKinematic = false;

          //  Debug.Log("direkszyn: " + direction);

            if (speed == false)
                rb.velocity = new Vector2(direction * movement_speed, rb.velocity.y);
            else
            {
                rb.velocity = new Vector2(direction * movement_speed * 4, rb.velocity.y);
                
            }




        }
        else
        {
            rb.isKinematic = true;
        }

    }

    private void flip()
    {
        if (next == "right")
        {
        //    flip_right();
            flip_left();
            next = "left";
            return;
        }
        else
        {
            //flip_left();
            flip_right();
            next = "right";
            return;
        }

    }

    private bool flip_right()
    {
        if (direction < 0)
        {
            rb.AddForce(movement_speed * pushBack * direction, 0, 0);
            direction *= -1;
            return true;
        }
        else
            return false;
    }

    private bool flip_left()
    {
        if (direction > 0)
        {
            rb.AddForce(-movement_speed * pushBack * direction, 0, 0);
            direction *= -1;
            return true;
        }
        //else
            return false;
    }


    private void OnCollisionEnter(Collision collisionData)
    {
        if ((collisionData.gameObject.CompareTag(wall_rightTag)))
        {
            //  bool changed = false;
           // flip();
          //  flip_right();
            flip_left();
            //   Debug.Log("qwef");// flip_left(changed);




           // Debug.Log("Ściana! " + next);

        }

        if ((collisionData.gameObject.CompareTag(wall_leftTag)))
        {
          //  flip_left();
            flip_right();
        }

            

    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag(speedTag)))
        {
            speed = true;
            Invoke("TurnOffSpeed", czasSpeeda);
        }
        if ((other.gameObject.CompareTag(spongeTag)))
        {
            rb.AddForce(0, wysokoscSponga, 0);
        }
    }




} //koniec klasy