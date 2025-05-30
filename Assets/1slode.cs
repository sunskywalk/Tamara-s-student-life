using UnityEngine;
using UnityEngine.SceneManagement;

public class YourNewSceneLoader : MonoBehaviour
{
    public string targetSceneName = "YourTargetSceneName";

    void Update()
    {
        // Проверяем, была ли нажата клавиша пробел
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Загружаем указанную сцену
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
