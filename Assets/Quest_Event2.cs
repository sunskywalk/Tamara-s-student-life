// Quest_Event2.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Event2 : MonoBehaviour
{
    public bool Quest2;
    public GameObject Text1;
    public bool end_Quest2;

    // Start is called before the first frame update
    void Start()
    {
        // Здесь могут быть дополнительные действия при старте
    }

    // Update is called once per frame
    void Update()
    {
        if (!end_Quest2)
        {
            if (Quest2)
            {
                Text1.SetActive(true);
            }
            else
            {
                Text1.SetActive(false);
            }
        }
        else
        {
            Text1.SetActive(false);
        }
    }
}
