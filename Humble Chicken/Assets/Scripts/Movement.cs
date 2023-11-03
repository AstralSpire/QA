using log4net.Util;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    private Chicken chicken;
    // Start is called before the first frame update
   

    public Movement(Chicken _chicken)
    {
        chicken = _chicken;
    }

    public void MoveChicken(bool buttonPressed, float _minHeight, float _maxHeight, float _speedUp, float _speedDown)
    {
        if (buttonPressed == true)
        {
            chicken.transform.position += Vector3.up * Time.deltaTime * _speedUp;
            if (chicken.transform.position.y > chicken.maxHeight)
            {
                chicken.transform.position = new Vector3(chicken.transform.position.x, _maxHeight, chicken.transform.position.z);
            }
        }
        else
        {
            chicken.transform.position += Vector3.down * Time.deltaTime * _speedDown;
            if (chicken.transform.position.y < chicken.minHeight)
            {
                chicken.transform.position = new Vector3(chicken.transform.position.x, _minHeight, chicken.transform.position.z);
            }
        }
    }
}
