using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the current position of the mouse
        Vector3 mousePos2D = Input.mousePosition;

        //The camera's z position sets how far to push the mouse
        mousePos2D.z =- Camera.main.transform.position.z;

        //convert the point from 2d Screen space into 3d game
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //move the x position of this basket to the x position
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
}
