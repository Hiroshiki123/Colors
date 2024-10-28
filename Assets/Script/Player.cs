using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed;
    public float limiteTop;
    public float limiteBottom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        limiteTop = transform.position.y + 16;
        limiteBottom = transform.position.y - 16;
        if (Input.GetButton("Fire1"))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}
