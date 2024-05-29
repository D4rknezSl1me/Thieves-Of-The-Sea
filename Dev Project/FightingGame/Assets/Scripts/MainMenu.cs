using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private bool musicToggle = true;
    private bool optionsToggle = false;
    public Image iconON;
    public Image iconOFF;
    public Image optionsIcon;
    public Image homeIcon;
    public CanvasRenderer mainButtonContainer;
    public CanvasRenderer optionsButtonContainer;
    public AudioManager audioManager;
    public LevelChanger levelChanger;

    public void GoToScene(int sceneIndex)
    {
        audioManager.PlaySFX(audioManager.button);
        levelChanger.FadeToLevel(sceneIndex);
    }

    public void QuitApp()
    {
        audioManager.PlaySFX(audioManager.button);
        Application.Quit();
        Debug.Log("Application Has Quit.");
    }

    public void ToggleMute()
    {
        audioManager.PlaySFX(audioManager.page, .5f);
        audioManager.ToggleBGMusic();
        musicToggle = !musicToggle;
        if (musicToggle)
        {
            iconON.gameObject.SetActive(true);
            iconOFF.gameObject.SetActive(false);
        }
        else
        {
            iconON.gameObject.SetActive(false);
            iconOFF.gameObject.SetActive(true);
        }
    }

    public void ToggleOptionMenu()
    {
        audioManager.PlaySFX(audioManager.page, .5f);
        optionsToggle = !optionsToggle;
        if (!optionsToggle)
        {
            mainButtonContainer.gameObject.SetActive(true);
            optionsButtonContainer.gameObject.SetActive(false);
            optionsIcon.gameObject.SetActive(true);
            homeIcon.gameObject.SetActive(false);
        }
        else
        {
            mainButtonContainer.gameObject.SetActive(false);
            optionsButtonContainer.gameObject.SetActive(true);
            optionsIcon.gameObject.SetActive(false);
            homeIcon.gameObject.SetActive(true);
        }
    }
}
