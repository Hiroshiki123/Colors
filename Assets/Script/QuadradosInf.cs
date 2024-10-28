using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuadradosInf : MonoBehaviour
{

    public Vector3 startRotation;
    private float speedRotate;
    public float limitY;
    private float limitYtop;
    Vector2 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = startRotation;
        initialPosition = transform.position;
        PipePosition(transform.position.y);
        limitYtop = transform.position.y;
        speedRotate = 70;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, speedRotate * Time.deltaTime);

        
            if (transform.position.y < limitY)
            {
                PipePosition(limitYtop);
            speedRotate = Random.Range(50,100);
            }
        
            
            if (transform.position.y > limitYtop)
            {
                
                PipePosition(limitY);

            }
        
    }


    void PipePosition(float b)
    {
        transform.position = initialPosition;
        transform.position = new Vector3(transform.position.x, b);
    }
}
