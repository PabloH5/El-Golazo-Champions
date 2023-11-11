using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotinManager : MonoBehaviour
{
    public GameObject suela;
    public GameObject Smoke;

    public Material red;
    public Material green;
    public Material blue;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("SuelaRed"))
        {
            Smoke.SetActive(true);
            suela.SetActive(true);
            suela.GetComponent<Renderer>().material = red;
        }
        if (collision.gameObject.CompareTag("SuelaGreen"))
        {
            Smoke.SetActive(true);
            suela.SetActive(true);
            suela.GetComponent<Renderer>().material = green;
        }
        if (collision.gameObject.CompareTag("SuelaBlue"))
        {
            Smoke.SetActive(true);
            suela.SetActive(true);
            suela.GetComponent<Renderer>().material = blue;
        }
    }
}
