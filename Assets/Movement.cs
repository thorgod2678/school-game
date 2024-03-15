using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public int score;
    public ModeSelector mode;
    public string x;
    public TextMeshProUGUI text;


    public GameObject plus;
    public GameObject minus;
    public int Prevv;
    
    public AudioSource AudioSource;

    private int b;
    public GameObject hh;
    // Start is called before the first frame update
    void Start()
    {
        Prevv = score;
    }

    // Update is called once per frame
    void Update()
    {
       text.text = "Score: " + score.ToString();
        
        x = mode.curmode;
        
        Debug.Log(score);
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2 (2f, 0f)*speed*Time.deltaTime);
           // transform.Translate(2,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
             rb.AddForce(new Vector2(-2f, 0f) * speed*Time.deltaTime);
           // transform.Translate(-2, 0, 0);
        }

        PlusMinus();
        if (Input.GetKey(KeyCode.R))
        {
            b = 1;
        }
        if (Input.GetKey(KeyCode.U))
        {
            b = 0;
            hh.SetActive(true);
        }

        if (b== 1)
        { 
            RandomMove();
            hh.SetActive(false);
        }
        
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "waste")
        {
            if(collision.gameObject.GetComponent<Detect>().mode == x) 
            {
                score++;

                AudioSource.pitch = 1f;
                AudioSource.Play();

            }
            else
            {
                score--;
                AudioSource.pitch = 0.15f;
                AudioSource.Play();
            }
        }
    }


    public void PlusMinus()
    {
      

        if(score>Prevv)
        {
            plus.SetActive(true);
            minus.SetActive(false);
        }
        else if (score < Prevv)
        {
            minus.SetActive(true);
            plus.SetActive(false);
        }

        Prevv = score;
    }

    void Left()
    {
        rb.AddForce(new Vector2(2f, 0f) * -2200*Time.deltaTime);
    }

    void Right()
    {
        rb.AddForce(new Vector2(-2f, 0f) * -2200*Time.deltaTime);
    }


    void RandomMove()
    {
        var x = Random.Range(1, 3);
        var y = Random.Range(1, 4);
        if (x == 1)
        {
            Left();
           // mode.curmode = "Dry Waste";
        }

        if (x == 2)
        {
            Right();
            //mode.curmode = "Electronic Waste";
        }

        if(y== 1)
        {
           // mode.curmode = "Dry Waste";
        //   mode.color.sprite = mode.dry;
        }

        if(y==2)
        {
           //  mode.curmode = "Electronic Waste";
          //  mode.color.sprite = mode.Elec;
        }

        if (y == 3)
        {
           //  mode.curmode = "Wet Waste";
         //   mode.color.sprite = mode.wet;
        }
    }
}
