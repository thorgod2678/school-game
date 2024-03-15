using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public GameObject player;
    public Movement playerscore;
    public int score;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        playerscore = player.GetComponent<Movement>();
        playerscore.score = score;
        x = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
       // PlayerPrefs.SetInt("HighScore", playerscore.score);
       // PlayerPrefs.Save();
       if(playerscore.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", playerscore.score);
            PlayerPrefs.Save();
        }
      
    }


    public void LoadGame()
    {
        playerscore.score = x;
      
    }
}
