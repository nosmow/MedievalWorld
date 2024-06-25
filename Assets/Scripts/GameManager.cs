using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
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
            SceneManager.LoadScene("GameOver");
        }

        if (points == coins)
        {
            SceneManager.LoadScene("Win"); 
        }
    }

    public void AddPoints()
    {
        points++;
        coinsCollected.text = points.ToString();
        audioCoin.Play();
    }
}
