using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapStrength; 
    public Logic logic;
    bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
      logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        myrigidbody.velocity = Vector2.up * flapStrength;

        if(transform.position.y >17 || transform.position.y < -17)
        logic.gameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      logic.gameOver();
      birdIsAlive = false;
    }
}
