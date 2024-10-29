using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuadradosInf : MonoBehaviour
{

    public Vector3 startRotation;
    private float speedRotate;
    private float limitY;
    private float limitYtop;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = startRotation;
        PipePosition(transform.position.y);
        limitYtop = transform.position.y;
        speedRotate = 70;

        

    }

    // Update is called once per frame
    void Update()
    {
        limitYtop = player.limiteTop;
        limitY = player.limiteBottom;
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
        transform.position = new Vector3(transform.position.x, b);
    }
}
