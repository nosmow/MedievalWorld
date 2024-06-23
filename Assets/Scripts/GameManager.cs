using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string sceneName;
    [SerializeField] AudioSource audioCoin;
    [SerializeField] TextMeshProUGUI totalCoins;
    [SerializeField] TextMeshProUGUI coinsCollected;
    [SerializeField] TextMeshProUGUI timeLifeText;
    private float timeLife = 60;
    private int coins = 0;
    private int points = 0;

    void Start()
    {
        audioCoin = GetComponent<AudioSource>();
        coins = GameObject.FindGameObjectsWithTag("Coin").Length;
        totalCoins.text = coins.ToString();
    }

    private void Update()
    {
        timeLife -= Time.deltaTime;
        timeLifeText.text = Mathf.Ceil(timeLife).ToString();

        if (timeLife <= 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("GameOver");
        }

        if (points == coins)
        {    
            SceneManager.LoadScene(sceneName);
        }

    }

    public void AddPoints()
    {
        points++;
        coinsCollected.text = points.ToString();
        audioCoin.Play();
    }

}
