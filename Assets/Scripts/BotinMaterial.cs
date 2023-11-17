using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotinMaterial : MonoBehaviour
{
    public GameObject Botin;
    
    public GameObject BotinPieIzq;
    public GameObject BotinPieRgh;

    public Material red;
    public Material green;
    public Material blue;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("BotinRed"))
        {
            Botin.GetComponent<Renderer>().material = red;
            BotinPieIzq.GetComponent<Renderer>().material = red;
            BotinPieRgh.GetComponent<Renderer>().material = red;
        }
        if (collision.gameObject.CompareTag("BotinBlue"))
        {
            Botin.GetComponent<Renderer>().material = blue;
            BotinPieIzq.GetComponent<Renderer>().material = blue;
            BotinPieRgh.GetComponent<Renderer>().material = blue;
        }
        if (collision.gameObject.CompareTag("BotinGreen"))
        {
            Botin.GetComponent<Renderer>().material = green;
            BotinPieIzq.GetComponent<Renderer>().material = green;
            BotinPieRgh.GetComponent<Renderer>().material = green;
        }
        // if (collision.gameObject.CompareTag("Matalo"))
        // {
        //     Destroy(this.gameObject);
        // }
    }
}
