using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TimeSelector : MonoBehaviour
{
    [Header("Time Settings")]
    [Range(1f, 60f)] // ��������� �������� ��� ������ ������� �� 1 �� 60 ������
    public float selectedTime = 10f;

    void Start()
    {
        // �������������� ��������, ������� �� ������ ��������� � Start
    }

    void Update()
    {
        // �������������� ��������, ������� �� ������ ��������� � Update
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
