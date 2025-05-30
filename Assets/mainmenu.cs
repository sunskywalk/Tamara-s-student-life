using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButtonClicked()
    {
        // Загрузить сцену с игрой
        SceneManager.LoadScene("Slide1");
    }

    public void LanguagesButtonClicked()
    {
        // TODO: Добавьте логику для открытия меню выбора языка
        Debug.Log("Languages Menu Placeholder");
    }

    public void ExitButtonClicked()
    {
        // Закрыть приложение
        Application.Quit();
    }
}
