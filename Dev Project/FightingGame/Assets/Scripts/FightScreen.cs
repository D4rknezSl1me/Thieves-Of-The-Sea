using UnityEngine;

public class FightScreen : MonoBehaviour
{
    public LevelChanger levelChanger;
    public AudioManager audioManager;

    void Start()
    {
        audioManager.PlaySFX(audioManager.page);
    }
    private void Update()
    {
        if (levelChanger.fadeInCompleted)
        {
            levelChanger.FadeToLevel(2);
        }
    }
}
