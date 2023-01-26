using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject main, game, settings, win;
    public bool isActive;
    [SerializeField] private ParticleSystem win_partciles;
    private int sceneIndex;
    [SerializeField] private Text level;

    void Awake()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (PlayerPrefs.GetInt("level", 0) == sceneIndex)
        {

        }
        else SceneManager.LoadScene(PlayerPrefs.GetInt("level", 0));
    }

    void Start()
    {
        game.SetActive(false);
        main.SetActive(true);
        level.text += " " + (sceneIndex + 1).ToString();

        if (DontDestroy.wasPlayed)
        {
            Play();
            main.SetActive(false);
        }
    }
    public void Win()
    {
        win.SetActive(true);
        win_partciles.Play();
        PlayerPrefs.SetInt("level", sceneIndex + 1);
    }

    public void Play()
    {
        isActive = true;
        game.SetActive(true);
        DontDestroy.wasPlayed = true;
    }

    public void Settings()
    {
        game.SetActive(false);
        isActive = false;
    }

    public void Vibration()
    {
        if (PlayerPrefs.GetInt("vibration", 1) == 0)
        {
            return;
        }
        Handheld.Vibrate();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
