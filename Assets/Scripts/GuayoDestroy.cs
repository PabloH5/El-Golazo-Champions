using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuayoDestro : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Guayo"))
        {
            Destroy(this.gameObject);
        }
    }
}
