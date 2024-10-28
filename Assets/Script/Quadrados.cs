using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quadrados : MonoBehaviour
{

    public Vector3 startRotation;
    private float speedRotate;
    public float speedDescida;
    public float limitY;
    public float limitYtop;
    Vector2 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = startRotation;
        initialPosition = transform.position;
        PipePosition();
        limitYtop = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, speedRotate * Time.deltaTime);

        if (Input.GetButton("Fire1"))
        {
            transform.Translate(Vector2.down * speedDescida * Time.deltaTime);
            if (transform.position.y < limitY)
            {

                PipePosition();
            }
        }
        else
        {
            transform.Translate(Vector2.up * speedDescida * Time.deltaTime);
            if (transform.position.y > limitYtop)
            {

                PipePosition();
            }
        }
    }


    void PipePosition()
    {
        transform.position = initialPosition;
        transform.position = new Vector3(transform.position.x, transform.position.y);
    }
}
