using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itens : MonoBehaviour
{
    private SpriteRenderer sr;
    private BoxCollider2D Box;

    public GameObject collected;
    public int Pontuação;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            Box.enabled = false;
            collected.SetActive(true);

            GameController.instance.totalScore += Pontuação;
            GameController.instance.UpdateScoreText();

            Destroy(gameObject, 0.7f);
        }
    }

}
