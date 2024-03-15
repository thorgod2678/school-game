using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Detect : MonoBehaviour
{
     public ModeSelector modeSelector;
    public string mode;
    //public string x;
    //public int score;
    public TextMeshProUGUI x;
    public Manger kk;
    
    // Start is called before the first frame update
    void Start()
    {
       modeSelector = GameObject.FindGameObjectWithTag("player").GetComponent<ModeSelector>();
        //x= GameObject.FindGameObjectWithTag("text").GetComponent<TextMeshProUGUI>();
        kk = GameObject.FindGameObjectWithTag("manger").GetComponent<Manger>();
    }

    // Update is called once per frame
    void Update()
    {
       // x.text = "Score: " + score;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            if(collision.gameObject.tag == "player")
            {
                if(modeSelector.curmode == mode)
                {
                    Debug.Log("Sucsess");
                    //score++;
                    // Destroy(this.gameObject);
                    Destroyornot();
                }
            }
            else
            {
                Debug.Log("Fail");
            }


            if(collision.gameObject.tag == "floor")
            {
                //Destroy(this.gameObject);
                Destroyornot();
            }
        }
    }

    public void Destroyornot()
    {
        if(kk.jj == true)
        {
            Destroy(gameObject);
        }
        else if(kk.jj == false)
        {
            Debug.Log("Hard Mode");
        }
    }
}
