using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Quest2 : MonoBehaviour
{
    public Quest_Event2 QEvent2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col2)
    {
        if (col2.CompareTag("Player"))
        {
            QEvent2.end_Quest2 = true;
            Destroy(gameObject);
        }
    }
}
