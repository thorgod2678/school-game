
using UnityEngine;

public class ModeSelector : MonoBehaviour
{
    public string[] modes;
    public string curmode;
    public SpriteRenderer color;
    public Sprite dry;
    public Sprite wet;
    public Sprite Elec;

    private void Awake()
    {
        curmode = modes[0];
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            curmode = modes[0];
            //color.color = Color.white;
            color.sprite = dry;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            curmode = modes[1];
            // color.color = Color.blue;
            color.sprite = wet;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            curmode = modes[2];
            //color.color = Color.yellow;
            color.sprite = Elec;
        }
    }
}
