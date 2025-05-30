// NPC_Task.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog1;
    public GameObject Dialog2;
    public Quest_Event QE;
    public bool Fin_Dialog;
    private bool onHide;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (QE.end_Quest1 == true)
        {
            Fin_Dialog = true;
        }

        if (EndDialog)
        {
            Time.timeScale = 1;
            QE.Quest1 = true;
            Dialog1.SetActive(false);
        }

        if (Fin_Dialog)
        {
            Time.timeScale = 1;
            QE.Quest1 = false;
            Dialog1.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Dialog2.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Time.timeScale = 0;
            if (QE.end_Quest1 == false)
            {
                Dialog1.SetActive(true);
            }
            else
            {
                Dialog2.SetActive(true);
            }
        }
        else
        {
            if (onHide == false)
            {
                Dialog2.SetActive(true);
                onHide = true;
            }
        }
    }
}
