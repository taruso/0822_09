using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField]
    GameObject Title = null;
    [SerializeField]
    GameObject Game = null;
    [SerializeField]
    InGame inGame = null;


    // Start is called before the first frame update
    void Start()
    {
        if (inGame.StageNum == 0)
        {
            Title.SetActive(true);
            Game.SetActive(false);
        }
        else
        {
            Title.SetActive(false);
            Game.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        Title.SetActive(false);
        Game.SetActive(true);
    }
}
