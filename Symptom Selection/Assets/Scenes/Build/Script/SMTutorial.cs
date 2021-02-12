using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SMTutorial : MonoBehaviour
{

    public enum GameState { K1State, K2State, K3State, K4State, K5State };
    public GameState currentGameState;

 
    public GameObject K1;
    public GameObject K2;
    public GameObject K3;
    public GameObject K4;
    public GameObject K5;

    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;

    public GameObject panel1;

    // Use this for initialization
    void Start()
    {
        currentGameState = GameState.K1State;
        ShowScreen(K1);
        panel1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        
        K1.SetActive(false);
        K2.SetActive(false);
        K3.SetActive(false);
        K4.SetActive(false);
        K5.SetActive(false);

        gameObjectToShow.SetActive(true);
    }


    public void Knowledge1()
    {
        currentGameState = GameState.K1State;
        ShowScreen(K1);
    }
    public void Knowledge2()
    {
        currentGameState = GameState.K2State;
        ShowScreen(K2);
    }
    public void Knowledge3()
    {
        currentGameState = GameState.K3State;
        ShowScreen(K3);
    }
    public void Knowledge4()
    {
        currentGameState = GameState.K4State;
        ShowScreen(K4);
    }
    public void Knowledge5()
    {
        currentGameState = GameState.K5State;
        ShowScreen(K5);
    }
    public void Play()
    {
        panel1.gameObject.SetActive(true);
    }
    public void Choice1()
    {
        SceneManager.LoadScene("Play1");
    }
    public void Choice2()
    {
        SceneManager.LoadScene("Play2");
    }
    public void Choice3()
    {
        SceneManager.LoadScene("Play3");
    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }

}