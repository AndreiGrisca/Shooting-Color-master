using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private RectTransform main, game, settings, win, pause, soundToggle, vibrationToggle;
    [SerializeField] private GameObject soundT, vibrationT;
    [SerializeField] private Sprite toggleOn, toggleOff;
    [SerializeField] private GameManager game_manager;

    void Awake()
    {
        SoundToggle(soundT, PlayerPrefs.GetInt("music", 1));
        VibrationToggle(vibrationT, PlayerPrefs.GetInt("vibration", 1));

    }

    public void PlayButton()
    {
        main.DOAnchorPos(new Vector2(-1082, 0), 0.35f);
        game_manager.Play();
    }

    public void PauseButton()
    {
        main.DOAnchorPos(new Vector2(0, 0), 0.35f);
    }

    public void RestartButton()
    {
    }

    public void GoToSettings()
    {
        main.DOAnchorPos(new Vector2(-1082, 0), 0.35f);
        settings.DOAnchorPos(new Vector2(0, 0), 0.35f);
        game_manager.Settings();
    }

    public void Back()
    {
        settings.DOAnchorPos(new Vector2(1082, 0), 0.35f);
        game_manager.Play();
    }

    public void NextLevel()
    {
        win.DOAnchorPos(new Vector2(-1082, 0), 0.35f);
        game_manager.NextLevel();
    }

    public void SoundSettings()
    {
        if (PlayerPrefs.GetInt("music", 1) == 1)
        {
            PlayerPrefs.SetInt("music", 0);
            soundToggle.DOAnchorPos(new Vector2(-50, 0), 0.2f);
        }
        else
        {
            PlayerPrefs.SetInt("music", 1);
            soundToggle.DOAnchorPos(new Vector2(50, 0), 0.2f);
        }
        SoundToggle(soundT, PlayerPrefs.GetInt("music", 1));
    }

    public void SoundToggle(GameObject button, int state)
    {
        if (state == 0)
        {
            soundT.GetComponent<Image>().sprite = toggleOff;
            soundToggle.anchoredPosition = new Vector2(-50, 0);
        }
        else
        {
            soundT.GetComponent<Image>().sprite = toggleOn;
            soundToggle.anchoredPosition = new Vector2(50, 0);
        }
    }
    public void VibrationSettings()
    {
        if (PlayerPrefs.GetInt("vibration", 1) == 1)
        {
            PlayerPrefs.SetInt("vibration", 0);
            vibrationToggle.DOAnchorPos(new Vector2(-50, 0), 0.2f);
        }
        else
        {
            PlayerPrefs.SetInt("vibration", 1);
            vibrationToggle.DOAnchorPos(new Vector2(50, 0), 0.2f);
        }
        VibrationToggle(soundT, PlayerPrefs.GetInt("vibration", 1));
    }

    public void VibrationToggle(GameObject button, int state)
    {
        if (state == 0)
        {
            vibrationT.GetComponent<Image>().sprite = toggleOff;
            vibrationToggle.anchoredPosition = new Vector2(-50, 0);
        }
        else
        {
            vibrationT.GetComponent<Image>().sprite = toggleOn;
            vibrationToggle.anchoredPosition = new Vector2(50, 0);
        }
    }

}
