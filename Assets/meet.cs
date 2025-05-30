using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    public string npcTag = "NPC"; // ������� ��� NPC
    private bool eventCompleted = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(npcTag) && !eventCompleted)
        {
            CompleteEvent();
        }
    }

    void CompleteEvent()
    {
        Debug.Log("����� ��������. ����� ���������������� � NPC!");
        eventCompleted = true;
        // �������������� �������� ��� ���������� ������ ����� ���� ��������� �����
    }
}
