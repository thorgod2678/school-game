using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manger : MonoBehaviour
{
    //public Detect detectdry;
    //public Detect detectwet;
    //public Detect detectelec;
    //public TextMeshProUGUI dd;

    public Toggle dd;
    public bool jj;
    
    // Start is called before the first frame update
    void Start()
    {
        pausetime();

        
    }

    // Update is called once per frame
    void Update()
    {
        jj= dd.isOn;



        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }


    // public void Score()
    //{
    // detectwet = GameObject.FindGameObjectWithTag("wetwaste").GetComponent<Detect>();
    // detectdry = GameObject.FindGameObjectWithTag("drywaste").GetComponent<Detect>();
    // detectelec = GameObject.FindGameObjectWithTag("electronicwaste").GetComponent<Detect>();

    //int wetscore = detectwet.score;
    // int dryscore = detectdry.score;
    // int electscore = detectelec.score;

    // int fscore = wetscore + dryscore + electscore;

    // dd.text = "Score: " + fscore.ToString();
    //}

    public void pausetime()
    {
        Time.timeScale = 0f;
    }

    public void Resumetime()
    {
        Time.timeScale = 1f;
    }
}

