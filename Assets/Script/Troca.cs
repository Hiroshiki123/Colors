using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troca : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;
    [SerializeField] CircleCollider2D circle;
    private float limitY = -25;
    private float limitYtop = 25;
    public Player player;
    // Start is called before the first frame update
    void Update()
    {
        limitY = player.limiteBottom;
        limitYtop = player.limiteTop;



        if (transform.position.y < limitY)
        {
            PipePosition(limitYtop);
            sr.enabled = true;
            circle.enabled = true;

        }


        if (transform.position.y > limitYtop)
        {

            PipePosition(limitY);

        }

    }


    void PipePosition(float b)
    {
        transform.position = new Vector3(transform.position.x, b);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            
        }
    }

}
