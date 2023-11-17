using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGuayos : MonoBehaviour
{
    public GameObject Botin1;
    public GameObject Botin2;


    public GameObject Botin3;
    public GameObject Botin4;

    public GameObject boton;
    public GameObject canva;
    public Material red;
    public Material green;
    public Material blue;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Union"))
        {
            canva.SetActive(false);
            Botin1.SetActive(true);
            Botin2.SetActive(true);
            boton.SetActive(true);
            Destroy(Botin3.gameObject);
            Destroy(Botin4.gameObject);
        }
    }
}
