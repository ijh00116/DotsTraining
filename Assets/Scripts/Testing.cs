using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        entityManager.CreateEntity();
    }

   
}
