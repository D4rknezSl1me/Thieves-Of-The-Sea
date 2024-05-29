using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    public bool fadeInCompleted = false;
    private int levelToLoad;

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeInStart()
    {
        fadeInCompleted = false;
    }

    public void OnFadeInComplete()
    {
        fadeInCompleted = true;
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
