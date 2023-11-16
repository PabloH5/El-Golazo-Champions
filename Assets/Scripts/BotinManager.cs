using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotinManager : MonoBehaviour
{
    public GameObject suela;
    public GameObject Smoke;

    public GameObject BotinPieIzq;
    public GameObject SuelaPieIzq;
    public GameObject BotinPieRgh;
    public GameObject SuelaPieRgh;

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
            BotinPieIzq.GetComponent<Renderer>().material = red;
            SuelaPieIzq.GetComponent<Renderer>().material = red;
            BotinPieRgh.GetComponent<Renderer>().material = red;
            SuelaPieRgh.GetComponent<Renderer>().material = red;
            
        }
        if (collision.gameObject.CompareTag("SuelaGreen"))
        {
            Smoke.SetActive(true);
            suela.SetActive(true);
            suela.GetComponent<Renderer>().material = green;
            BotinPieIzq.GetComponent<Renderer>().material = green;
            SuelaPieIzq.GetComponent<Renderer>().material = green;
            BotinPieRgh.GetComponent<Renderer>().material = green;
            SuelaPieRgh.GetComponent<Renderer>().material = green;
        }
        if (collision.gameObject.CompareTag("SuelaBlue"))
        {
            Smoke.SetActive(true);
            suela.SetActive(true);
            suela.GetComponent<Renderer>().material = blue;
            BotinPieIzq.GetComponent<Renderer>().material = blue;
            SuelaPieIzq.GetComponent<Renderer>().material = blue;
            BotinPieRgh.GetComponent<Renderer>().material = blue;
            SuelaPieRgh.GetComponent<Renderer>().material = blue;
        }
    }
}
