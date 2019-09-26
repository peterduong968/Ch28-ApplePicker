using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    //prefab for instantiating apples
    public GameObject applePrefab;

    //speed at which apple tree moves
    public float speed = 1f;

    //Distance where apple tree turns around
    public float leftAndRightEdge = 10f;

    //Chance the apple tree will change direction
    public float chanceToChangeDirections = .1f;

    //rate at which apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;

    void Start()
    {
        
    }

   void Update()
    {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //changing direction
        //too far left
        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        //too far right
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        else  if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
