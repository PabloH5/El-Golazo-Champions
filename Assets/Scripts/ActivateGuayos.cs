using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGuayos : MonoBehaviour
{
    public GameObject Botin1;
    public GameObject Botin2;
    
    public Material red;
    public Material green;
    public Material blue;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Union"))
        {
            Botin1.SetActive(true);
            Botin2.SetActive(true);
        }
    }
}
