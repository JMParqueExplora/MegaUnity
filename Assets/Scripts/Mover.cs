using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 5f;
    public float jumpf = 10f;
    public bool jump = false;
    public float dirX = 0f;
    public SpriteRenderer spr;
    public Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(dirX *speed*Time.deltaTime, 0, 0);
        //transform.Translate (Vector3.right*dirX*speed*Time.deltaTime);

        if (dirX > 0 )
        {
            spr.flipX = false;
        }

        if (dirX < 0)
        {
            spr.flipX = true;
        }

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        if(Input.GetMouseButtonDown (0))
        {
            jump = true;
        }
        
    }

    void FixedUpdate()
    {

        if(jump)
        {
            rb2d.AddForce(Vector2.up * jumpf, ForceMode2D.Impulse);
            jump = false;
        }
    }



}
