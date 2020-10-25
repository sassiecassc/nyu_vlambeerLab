using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jellyfishGen : MonoBehaviour
{
    public Vector3 destination;
    public float swimSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, destination, swimSpeed * Time.deltaTime);

        Debug.DrawLine(transform.position, destination, Color.cyan);


        //Distance code to determine if fish is close - then set new random position
        if(Vector2.Distance(transform.position, destination)< 1f)
        {

            destination = new Vector3(Random.Range(-40f, 40f), Random.Range(-40f, 40f), 0f);

        }

        //keep jellyfish pointed in the right direction
        transform.right = destination - transform.position;



        
    }
}
