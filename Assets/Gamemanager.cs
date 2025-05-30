using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isPaused = false;
    public Camera mainCamera; // Ссылка на основную камеру в сцене

    private void Start()
    {
        // Получаем ссылку на основную камеру при запуске
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Проверяем, была ли нажата клавиша "Escape"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Вызываем метод TogglePause() при нажатии "Escape"
            TogglePause();
        }

        // Проверяем, была ли нажата клавиша "L"
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Вызываем метод LoadNewScene() при нажатии "L"
            LoadNewScene();
        }

        // Проверяем, была ли нажата клавиша Backspace
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            // Вызываем метод ExitGame() при нажатии Backspace
            ExitGame();
        }
    }

    // Метод для открытия и закрытия меню паузы
    private void TogglePause()
    {
        // Инвертируем состояние паузы
        isPaused = !isPaused;

        if (isPaused)
        {
            // Замораживаем камеру
            mainCamera.enabled = false;

            // Загружаем сцену меню паузы
            SceneManager.LoadScene("pauseMenu", LoadSceneMode.Additive);
        }
        else
        {
            // Размораживаем камеру
            mainCamera.enabled = true;

            // Выгружаем сцену меню паузы
            SceneManager.UnloadSceneAsync("pauseMenu");
        }
    }

    // Метод для загрузки новой сцены
    private void LoadNewScene()
    {
        // Загружаем новую сцену
        SceneManager.LoadScene("Tamara");
    }

    // Метод для выхода из игры
    private void ExitGame()
    {
        // Завершаем приложение (работает в редакторе Unity и при сборке)
        Application.Quit();
    }
}
