using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    private Movement movement;
    public float minHeight = -3;
    public float maxHeight = 3;
    public float speedUp = 8f;
    public float speedDown = 3f;

    private void Start()
    {
        movement = new Movement(this);
    }
    void Update()
    {
        movement.MoveChicken(Input.GetMouseButton(0) || (Input.GetKey(KeyCode.Space)) , minHeight , maxHeight , speedUp , speedDown);
    }

    
}
   
    
