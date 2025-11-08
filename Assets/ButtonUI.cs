using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    public void gitHubLink()
    {
        Application.OpenURL("https://github.com/JxshiCodes/2d-fighting-game");
    }

    public void playButton()
    {
        SceneManager.LoadScene("CharacterSelect");
    }
    public void commandListButton()
    {
        SceneManager.LoadScene("CommandList");
    }
    public void settingsButton()
    {
        SceneManager.LoadScene("Settings");
    }
}
