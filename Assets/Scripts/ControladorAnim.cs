using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnim : MonoBehaviour
{

    public Animator animadorObj;
    void Start()
    {
        animadorObj = gameObject.GetComponent<Animator>();
    }

    public void ActivarMov()
    {
        animadorObj.SetBool("Dale", true);
        Destroy (GameObject.FindWithTag("BotinRed"));
        Destroy (GameObject.FindWithTag("BotinBlue"));
        Destroy (GameObject.FindWithTag("BotinGreen"));
        Destroy (GameObject.FindWithTag("SuelaRed"));
        Destroy (GameObject.FindWithTag("SuelaGreen"));
        Destroy (GameObject.FindWithTag("SuelaBlue"));


    }
}
