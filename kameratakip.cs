using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public GameObject obje;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(obje.transform.position.x, obje.transform.position.y, -10f);
    }
}
