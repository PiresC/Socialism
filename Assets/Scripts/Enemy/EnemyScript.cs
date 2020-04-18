using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    private float waitTime;
    public float startWaitTime;
    private int randomSpots;
    private float tempSpeed;
    private Animator anim;


    private float currentXPosition;
    private float currentYPosition;
    private bool isAttacking;

    private Transform target;

    public Transform Target { get => target; set => target = value; }

    void Start()
    {
        anim = GetComponent<Animator>();
        randomSpots = Random.Range(0, moveSpots.Length);

        currentXPosition = gameObject.transform.position.x;
        currentYPosition = gameObject.transform.position.y;
    }


    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
       // patrol();
        followTarget();

        if(gameObject.transform.position.x > currentXPosition)
        {
            anim.SetFloat("moveX", 1f);
        }
        if (gameObject.transform.position.x < currentXPosition)
        {
            anim.SetFloat("moveX", -1f);
        }
        if (gameObject.transform.position.y > currentYPosition)
        {
            anim.SetFloat("moveY", 1f);
        }
        if (gameObject.transform.position.y < currentYPosition)
        {
            anim.SetFloat("moveY", -1f);
        }
        if(speed == 0)
        {
            anim.SetFloat("moveX", 0f);
            anim.SetFloat("moveY", 0f);
        }
        currentXPosition = gameObject.transform.position.x;
        currentYPosition = gameObject.transform.position.y;

        if (isAttacking)
        {
            anim.SetTrigger("attack");
            isAttacking = false;
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            tempSpeed = speed;
            speed = 0;
            isAttacking = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            speed = tempSpeed;
        }
    }


    private void followTarget()
    {
        if(Target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
        }
    }

    private void patrol()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpots].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, moveSpots[randomSpots].position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                randomSpots = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

  
}
