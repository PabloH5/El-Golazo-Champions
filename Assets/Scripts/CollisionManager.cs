using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Union"))
        {
            Debug.Log("Desaparezco");
            Destroy(this.gameObject);
        }
    }
}
