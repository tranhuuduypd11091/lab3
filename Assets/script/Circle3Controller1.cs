using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle3Controller1 : MonoBehaviour
{
    private int direction = 1;
    private float moveSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0f,direction,0f);
        transform.Translate(movement* moveSpeed*Time.deltaTime);
        if(transform.position.y>4.41f|| transform.position.y<1.46f)
        {
            direction *=-1;
        }
    }
}
