using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PMTestScript
{
    Chicken chicken;
    Movement movement;
    GameObject gameGameObject;
    [SetUp]
    public void Setup()
    {
        gameGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));
        chicken = gameGameObject.GetComponentInChildren<Chicken>();
        movement = new Movement(chicken); 

}
    [TearDown]
    public void Teardown()
    {
    Object.Destroy(gameGameObject);
    }

    }
