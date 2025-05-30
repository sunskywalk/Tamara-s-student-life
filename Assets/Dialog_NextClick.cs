// Dialog_NextClick.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_NextClick : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    private bool isText1 = true;
    public NPC_Task npc_taskScript;
    public bool Fin_Dialog;
    public GameObject ObjectQuest;
    private bool dialogueCompleted = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isText1)
            {
                isText1 = false;
            }
            else
            {
                if (!dialogueCompleted)
                {
                    if (Fin_Dialog == false)
                    {
                        ObjectQuest.SetActive(true);
                        npc_taskScript.EndDialog = true;
                    }
                    else
                    {
                        npc_taskScript.Fin_Dialog = true;
                        dialogueCompleted = true; // Добавлено обновление dialogueCompleted
                    }
                    isText1 = true;
                }
            }
        }

        if (isText1 && !dialogueCompleted)
        {
            Text1.SetActive(true);
            Text2.SetActive(false);
        }
        else
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
        }
    }
}
