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

    }
}
