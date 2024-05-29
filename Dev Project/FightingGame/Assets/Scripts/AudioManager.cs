using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------------ Audio Sources -----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------------ Audio Clips -----------")]
    public AudioClip background;
    public AudioClip button;
    public AudioClip page;

    private bool playingBG = true;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void ToggleBGMusic()
    {
        playingBG = !playingBG;
        if (playingBG)
        {
            musicSource.Play();
        }
        else
        {
            musicSource.Pause();
        }
    }

    public void PlaySFX(AudioClip clip, float volumeScale=1f)
    {
        SFXSource.PlayOneShot(clip, volumeScale);
    }
}
