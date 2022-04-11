using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static int numberOfCoins;
    public Text CoinsText;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        numberOfCoins = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        CoinsText.text = "Coins:" + numberOfCoins;
    }
}
