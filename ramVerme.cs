using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramVerme : MonoBehaviour
{
   
    void Start()
    {
        
    }
    float ram = hareket.ram;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.name == "Oyuncu")
        {

            Destroy(gameObject);
         
            if (ram <= 100)
            {

                hareket.ram +=  35.0f;
            }
         

        }
    }
    void Update()
    {
        
    }
}
