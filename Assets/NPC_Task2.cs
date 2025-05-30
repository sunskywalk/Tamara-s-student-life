// NPC_Task.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task2 : MonoBehaviour
{
    public bool EndDialog2;
    public GameObject Dialog3;
    public GameObject Dialog4;
    public Quest_Event2 QE2;
    public bool Fin_Dialog2;
    private bool onHide2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (QE2.end_Quest2 == true)
        {
            Fin_Dialog2 = true;
        }

        if (EndDialog2)
        {
            Time.timeScale = 1;
            QE2.Quest2 = true;
            Dialog4.SetActive(false);
        }

        if (Fin_Dialog2)
        {
            Time.timeScale = 1;
            QE2.Quest2 = false;
            Dialog4.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Dialog4.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col2)
    {
        if (col2.CompareTag("Player"))
        {
            Time.timeScale = 0;
            if (QE2.end_Quest2 == false)
            {
                Dialog3.SetActive(true);
            }
            else
            {
                Dialog4.SetActive(true);
            }
        }
        else
        {
            if (onHide2 == false)
            {
                Dialog4.SetActive(true);
                onHide2 = true;
            }
        }
    }
}
