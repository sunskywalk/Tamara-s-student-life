using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string targetSceneName = "Slide2";

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
