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
    // Start is called before the first frame update
    void Start()
    {
        color = Random.Range(1, 4);
        spritecor = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        limiteTop = transform.position.y + 16;
        limiteBottom = transform.position.y - 16;
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
        if (Input.GetButton("Fire1"))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ciano")
        {

        }
        if (collision.gameObject.tag == "amarelo")
        {

        }
        if (collision.gameObject.tag == "rosa")
        {

        }
        if (collision.gameObject.tag == "roxo")
        {

        }
    }
}
