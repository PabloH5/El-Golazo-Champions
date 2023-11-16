using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGuayos : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Guayo"))
        {

        }
    }
}
