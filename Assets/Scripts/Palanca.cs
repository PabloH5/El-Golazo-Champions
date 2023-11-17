using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class Palanca : MonoBehaviour
{
    public Animator animadorObj;
    public ControladorAnim ControladorAnim; // Asegúrate de que esta variable esté correctamente declarada

    // Start is called before the first frame update
    void Start()
    {
        // Obtén el componente Button del objeto llamado "Activador"
        Button activadorButton = GameObject.Find("Activador").GetComponent<Button>();

        // Obtén el componente ControladorAnim del objeto con el componente Button
        ControladorAnim = activadorButton.GetComponent<ControladorAnim>();

        // Agrega un listener al botón de VR
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => Activar());

        // Obtén el componente Animator del objeto actual
        animadorObj = GetComponent<Animator>();
    }

    public void Activar()
    {
        animadorObj.SetBool("Dale", true);

        // Llama al método ActivarMov en el script ControladorAnim
        if (ControladorAnim != null)
        {
            ControladorAnim.ActivarMov();
        }
    }
}
