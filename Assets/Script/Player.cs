using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed;
    public float limiteTop;
    public float limiteBottom;
    private float color;
    private SpriteRenderer spritecor;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        color = Random.Range(1, 4);
        spritecor = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        limiteBottom = -25;
        limiteTop = 25;
    }

    // Update is called once per frame
    void Update()
    {
        limiteTop = transform.position.y + 25;
        limiteBottom = transform.position.y - 25;
        if (Input.GetButton("Fire1"))
        {
            rb.velocity = Vector2.up*speed;
        }
        if (color == 1)
        {
            spritecor.color = new Color(0,255,255,255);
        }else if (color == 2)
        {
            spritecor.color = new Color(255, 255, 0, 255);
        }
        else if (color == 3)
        {
            spritecor.color = new Color(255, 0, 255, 255);
        }
        else if (color == 4)
        {
            spritecor.color = new Color(125, 0, 255, 255);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ciano")
        {
            if (color != 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "amarelo")
        {
            if (color != 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "rosa")
        {
            if (color != 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "roxo")
        {
            if (color != 4)
            {
                Destroy(gameObject);
            }
        }
        if(collision.gameObject.tag == "troca")
        {
            color = Random.Range(1, 4);
        }
    }
}
