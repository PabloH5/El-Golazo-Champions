using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuayoDestro : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 pos;
    private Vector3 fixedRotation = new Vector3(335.690491f, 137.132233f, 238.832764f);

    private void Start()
    {
        pos = prefab.transform.position;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Guayo"))
        {
            Quaternion rotation = Quaternion.Euler(fixedRotation);
            Instantiate(prefab, pos, rotation);
            Destroy(this.gameObject);
        }
    }
}
