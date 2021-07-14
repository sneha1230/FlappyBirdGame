using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public GameObject gameOverPanel,scoreObj;

    //game states
    public static bool gameOver;
    public static bool gameHasStarted;
    public static bool gameIsPaused;
    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameHasStarted = false;
        gameIsPaused = false;
    }
    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        scoreObj.SetActive(false);
    }
    public void OnOkButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
