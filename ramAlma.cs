using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ramAlma : MonoBehaviour
{
    float ram = hareket.ram;

    void Start()
    {
    
    }
    
  
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.name == "Oyuncu")
        {

            Destroy(gameObject);
            if(satinAlma.pythonS==3)
            {
                hareket.ram -= 7.5f;
            }
            else
            {
                hareket.ram -= 15.0f;
            }
            
           

        }
    }
        void Update()
    {
       
    }
    private void FixedUpdate()
    {
      
    }
}
