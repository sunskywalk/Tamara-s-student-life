using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string targetSceneName = "Slide2";

    void Update()
    {
        // ���������, ���� �� ������ ������� ������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ��������� ��������� �����
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
