using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButtonClicked()
    {
        // ��������� ����� � �����
        SceneManager.LoadScene("Slide1");
    }

    public void LanguagesButtonClicked()
    {
        // TODO: �������� ������ ��� �������� ���� ������ �����
        Debug.Log("Languages Menu Placeholder");
    }

    public void ExitButtonClicked()
    {
        // ������� ����������
        Application.Quit();
    }
}
