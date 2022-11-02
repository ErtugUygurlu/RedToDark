using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public bool isstart;
    [SerializeField] private GameObject levelup;

    [SerializeField] private Image[] stars;
    public int star_count;

    private int levelindex;

    void Start()
    {
        isstart = false;
        levelindex = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        for (int i = 0; i < star_count; i++)
        {
            stars[i].enabled = true;
        }
    }

    void levelpanel()
    {
        levelup.SetActive(true);
    }

    public void levelupdate()
    {
        SceneManager.LoadScene(levelindex + 1);

    }

    public void GameOver()
    {
        SceneManager.LoadScene(levelindex);
    }
}
