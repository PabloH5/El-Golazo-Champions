using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 pos;
    private Vector3 fixedRotation = new Vector3(12.4449978f, 194.818985f, 50.8339958f);

    private void Start()
    {
        pos = prefab.transform.position;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Union"))
        {
            Quaternion rotation = Quaternion.Euler(fixedRotation);
            Instantiate(prefab, pos, rotation);
            Destroy(this.gameObject);
        }
    }
}
