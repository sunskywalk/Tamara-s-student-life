using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Переменная, определяющая, открыто ли меню в данный момент
    private bool isMenuOpen = false;

    // Метод для открытия и закрытия меню паузы
    private void TogglePauseMenu()
    {
        // Инвертируем состояние меню
        isMenuOpen = !isMenuOpen;

        // Ваш код для открытия и закрытия меню, например, изменение активности объектов в меню
        gameObject.SetActive(isMenuOpen);

        // Дополнительные действия при открытии и закрытии меню могут быть добавлены здесь
    }

    private void Update()
    {
        // Проверяем, была ли нажата клавиша "Escape"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Вызываем метод TogglePauseMenu() при нажатии "Escape"
            TogglePauseMenu();
        }
    }

    // Метод для кнопки "Resume"
    public void ResumeButtonClicked()
    {
        // Возвращаемся к продолжению игры при нажатии "Resume"
        ResumeGame();
    }

    public void ExitButtonClicked()
    {
        // Закрыть приложение
        Application.Quit();
    }

    // Метод для продолжения игры
    private void ResumeGame()
    {
        // Закрываем меню при нажатии "Resume"
        isMenuOpen = false;
        gameObject.SetActive(false);

        // TODO: Добавьте дополнительную логику для продолжения игры, например, возобновление анимаций, движения и т.д.
        Debug.Log("Game Resumed");
    }
}
