using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotinManager : MonoBehaviour
{
    public GameObject suela;
    public GameObject cordon;
    public GameObject Smoke;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Suela"))
        {
            //AQUI VA LA ANIMACIÓN
            Smoke.SetActive(true);
            suela.SetActive(true);
            Debug.Log("Animacion de humo nashe");
        }
        if (collision.gameObject.CompareTag("Cordon"))
        {
            cordon.SetActive(true);
            Debug.Log("Animacion de humo nashe");
        }
    }
}
