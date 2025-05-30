using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TimeSelector : MonoBehaviour
{
    [Header("Time Settings")]
    [Range(1f, 60f)] // Указываем диапазон для выбора времени от 1 до 60 секунд
    public float selectedTime = 10f;

    void Start()
    {
        // Дополнительные действия, которые вы можете выполнить в Start
    }

    void Update()
    {
        // Дополнительные действия, которые вы можете выполнить в Update
    }

    public void StartDestruction()
    {
        StartCoroutine(DestroyAfterTime());
    }

    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(selectedTime);
        Destroy(gameObject);
    }
}
