using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    private Animator anim;
	private bool facingRight = false;
    public int HP = 6;
    private EnemyScript enemy;
    

    private PlayerAttackAnimation pam;
    public bool attacking;

    // Start is called before the first frame update
    void Start()
    {
        pam = GameObject.Find("Enemies").GetComponent<PlayerAttackAnimation>();
        //facingRight(false);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxisRaw("Horizontal")> 0.5f || Input.GetAxisRaw("Horizontal")< -0.5f ){
            transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * MoveSpeed * Time.deltaTime,0f,0f));

			if (Input.GetAxisRaw ("Horizontal") > 0.5f && !facingRight) 
			{
				Flip ();
				facingRight = true;
			} else if (Input.GetAxisRaw("Horizontal") < 0.5f && facingRight) 
			{
				Flip ();
				facingRight = false;
			}
        }

        if(Input.GetAxisRaw("Vertical")> 0.5f || Input.GetAxisRaw("Vertical")< -0.5f){
            transform.Translate (new Vector3(0f, Input.GetAxisRaw("Vertical") * MoveSpeed * Time.deltaTime,0f));
        }

       

        anim.SetFloat("moveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("moveY", Input.GetAxisRaw("Vertical"));


        if (pam.attacking)
        {
            anim.SetTrigger("Attack");
            pam.attacking = false;
        }
            
        
    }

    

    void Update()
    {
        if (HP == 0)
            SceneManager.LoadScene(6);
        
   
    }

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            HP--;
            // Debug.Log(HP);
  
        }
    }

}
