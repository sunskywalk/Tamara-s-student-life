using UnityEngine;
using UnityEngine.SceneManagement;

public class YourNewSceneLoader : MonoBehaviour
{
    public string targetSceneName = "YourTargetSceneName";

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
