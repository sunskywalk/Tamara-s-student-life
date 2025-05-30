using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // ����������, ������������, ������� �� ���� � ������ ������
    private bool isMenuOpen = false;

    // ����� ��� �������� � �������� ���� �����
    private void TogglePauseMenu()
    {
        // ����������� ��������� ����
        isMenuOpen = !isMenuOpen;

        // ��� ��� ��� �������� � �������� ����, ��������, ��������� ���������� �������� � ����
        gameObject.SetActive(isMenuOpen);

        // �������������� �������� ��� �������� � �������� ���� ����� ���� ��������� �����
    }

    private void Update()
    {
        // ���������, ���� �� ������ ������� "Escape"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // �������� ����� TogglePauseMenu() ��� ������� "Escape"
            TogglePauseMenu();
        }
    }

    // ����� ��� ������ "Resume"
    public void ResumeButtonClicked()
    {
        // ������������ � ����������� ���� ��� ������� "Resume"
        ResumeGame();
    }

    public void ExitButtonClicked()
    {
        // ������� ����������
        Application.Quit();
    }

    // ����� ��� ����������� ����
    private void ResumeGame()
    {
        // ��������� ���� ��� ������� "Resume"
        isMenuOpen = false;
        gameObject.SetActive(false);

        // TODO: �������� �������������� ������ ��� ����������� ����, ��������, ������������� ��������, �������� � �.�.
        Debug.Log("Game Resumed");
    }
}
