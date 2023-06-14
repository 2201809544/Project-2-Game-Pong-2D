using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Panel Player Win")]
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    [Header("Text untuk Score")]
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    [Header("Panel Player Win")]
    public GameObject panelWin;
    public TMP_Text playerWin;

   
    

    public static GameManager instance;
    public SceneManagement sm;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        panelWin.SetActive(false);
    }


    //Method penyeleksi untuk menambah score
    public void Score(string wallID)
    {
        if (wallID == "Line L")
        {
            PlayerScoreR = PlayerScoreR + 10; //Menambah score
            txtPlayerScoreR.text = PlayerScoreR.ToString(); //Mengisikan nilai integer PlayerScore ke UI
            ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();

        }
    }
    public void ScoreCheck()
    {
        if (PlayerScoreL == 10)
        {
            panelWin.SetActive(true);
            playerWin.text = "Player L Win!!!";
            Debug.Log("kepanggi 0");
            Invoke("ChangeTheScene", 2f);
        }
        else if (PlayerScoreR == 10)
        {
            panelWin.SetActive(true);
            Debug.Log("kepanggi 0");
            playerWin.text = "Player R Win!!!";
            Invoke("ChangeTheScene", 2f);
        }
    }

    public void ChangeTheScene() 
    {
        Debug.Log("kepanggi 1");
        //this.gameObject.SendMessage("ChangeTheScene", "MainMenu");
        sm.ChangeScene("MainMenu");
    }
}