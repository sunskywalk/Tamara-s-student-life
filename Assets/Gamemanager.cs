using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isPaused = false;
    public Camera mainCamera; // ������ �� �������� ������ � �����

    private void Start()
    {
        // �������� ������ �� �������� ������ ��� �������
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // ���������, ���� �� ������ ������� "Escape"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // �������� ����� TogglePause() ��� ������� "Escape"
            TogglePause();
        }

        // ���������, ���� �� ������ ������� "L"
        if (Input.GetKeyDown(KeyCode.L))
        {
            // �������� ����� LoadNewScene() ��� ������� "L"
            LoadNewScene();
        }

        // ���������, ���� �� ������ ������� Backspace
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            // �������� ����� ExitGame() ��� ������� Backspace
            ExitGame();
        }
    }

    // ����� ��� �������� � �������� ���� �����
    private void TogglePause()
    {
        // ����������� ��������� �����
        isPaused = !isPaused;

        if (isPaused)
        {
            // ������������ ������
            mainCamera.enabled = false;

            // ��������� ����� ���� �����
            SceneManager.LoadScene("pauseMenu", LoadSceneMode.Additive);
        }
        else
        {
            // ������������� ������
            mainCamera.enabled = true;

            // ��������� ����� ���� �����
            SceneManager.UnloadSceneAsync("pauseMenu");
        }
    }

    // ����� ��� �������� ����� �����
    private void LoadNewScene()
    {
        // ��������� ����� �����
        SceneManager.LoadScene("Tamara");
    }

    // ����� ��� ������ �� ����
    private void ExitGame()
    {
        // ��������� ���������� (�������� � ��������� Unity � ��� ������)
        Application.Quit();
    }
}
