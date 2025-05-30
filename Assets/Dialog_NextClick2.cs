using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_NextClick2 : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    private bool isText1 = true;
    public NPC_Task2 npc_taskScript2;
    public bool Fin_Dialog2;
    public GameObject ObjectQuest2;
    private bool dialogueCompleted2 = false;

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
                if (!dialogueCompleted2)
                {
                    if (Fin_Dialog2 == false)
                    {
                        ObjectQuest2.SetActive(true);
                        npc_taskScript2.EndDialog2 = true;
                    }
                    else
                    {
                        npc_taskScript2.Fin_Dialog2 = true;
                        dialogueCompleted2 = true;
                        // Очистка текстов и прерывание обновлений после завершения диалога
                        Text1.SetActive(false);
                        Text2.SetActive(false);
                        return;
                    }
                    isText1 = true;
                }
            }
        }

        if (isText1 && !dialogueCompleted2)
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
