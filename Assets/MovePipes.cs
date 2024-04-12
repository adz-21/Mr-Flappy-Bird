using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour
{
    public float speed = 3;
    public float deadzone = -35;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime; 
        // Time.deltaTime -- ensures the multiplication happens the same no matter the frame rate

        if(transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
        
    }
}
