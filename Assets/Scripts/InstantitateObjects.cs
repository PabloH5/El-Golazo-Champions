using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantitateObjects : MonoBehaviour
{
    public GameObject BotinRed;
    public GameObject BotinBlue;
    public GameObject BotinGreen;
    public GameObject SuelaBlue;
    public GameObject SuelaGreen;
    public GameObject SuelaRed;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("BotinRed"))
        {
            Instantiate(BotinRed, BotinRed.transform.position, BotinRed.transform.rotation);
        }
        if (collision.gameObject.CompareTag("BotinBlue"))
        {
            Instantiate(BotinBlue, BotinBlue.transform.position, BotinBlue.transform.rotation);
        }
        if (collision.gameObject.CompareTag("BotinGreen"))
        {
            Instantiate(BotinGreen, BotinGreen.transform.position, BotinGreen.transform.rotation);
        }
        if (collision.gameObject.CompareTag("SuelaBlue"))
        {
            Instantiate(SuelaBlue, SuelaBlue.transform.position, SuelaBlue.transform.rotation);
        }
        if (collision.gameObject.CompareTag("SuelaGreen"))
        {
            Instantiate(SuelaGreen, SuelaGreen.transform.position, SuelaGreen.transform.rotation);
        }
        if (collision.gameObject.CompareTag("SuelaRed"))
        {
            Instantiate(SuelaRed, SuelaRed.transform.position, SuelaRed.transform.rotation);
        }
    }
}
