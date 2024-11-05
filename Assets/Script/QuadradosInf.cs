using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuadradosInf : MonoBehaviour
{

    
    private float speedRotate;
    private float limitY = -25;
    private float limitYtop = 25;
    public Player player;
    // Start is called before the first frame update
    void Awake()
    {
        
        
        limitYtop = 25;
        limitY = -25;
        speedRotate = 70;
        PipePosition(transform.position.y);



    }

    // Update is called once per frame
    void Update()
    {
        limitY = player.limiteBottom;
        limitYtop = player.limiteTop;
        print(limitY);
        print(limitYtop);
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
