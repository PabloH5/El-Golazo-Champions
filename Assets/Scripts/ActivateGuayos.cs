using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGuayos : MonoBehaviour
{
    public GameObject Botin;

    public Material red;
    public Material green;
    public Material blue;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("BotinRed"))
        {
            Botin.SetActive(true);
            Botin.GetComponent<Renderer>().material = red;
        }
        if (collision.gameObject.CompareTag("BotinBlue"))
        {
            Botin.SetActive(true);
            Botin.GetComponent<Renderer>().material = blue;
        }
        if (collision.gameObject.CompareTag("BotinGreen"))
        {
            Botin.SetActive(true);
            Botin.GetComponent<Renderer>().material = green;
        }
    }
}
