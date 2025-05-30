using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    public string npcTag = "NPC"; // Укажите тег NPC
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
        Debug.Log("Ивент завершен. Игрок взаимодействовал с NPC!");
        eventCompleted = true;
        // Дополнительные действия при завершении ивента могут быть добавлены здесь
    }
}
