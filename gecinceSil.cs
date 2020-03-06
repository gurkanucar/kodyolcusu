using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gecinceSil : MonoBehaviour
{
    public Transform obje;
    void Start()
    {
        
    }

    
    void Update()
    {
        if((obje.transform.position.x - transform.position.x) > 100)
        {
            Destroy(this);
        }
    }
}
