using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SM2 : MonoBehaviour
{

    public enum GameState { IntroState, Q1State, Q2State, Q3State, Q4State, IncorrectState };
    public GameState currentGameState;

    public GameObject Intro;
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Incorrect;

    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;

    public SM sM;

    // Use this for initialization
    void Start()
    {
        currentGameState = GameState.IntroState;
        ShowScreen(Intro);
        Text1.text = "Hello " + sM.PlayerName + ", how are you today?";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        Intro.SetActive(false);
        Q1.SetActive(false);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Q4.SetActive(false);

        gameObjectToShow.SetActive(true);
    }



    public void Question1()
    {
        currentGameState = GameState.Q1State;
        ShowScreen(Q1);
        Text2.text = "The patient said that she feels itchy, so what kind of rash below she may has?";
    }
    public void Question2()
    {
        currentGameState = GameState.Q2State;
        ShowScreen(Q2);
    }
    public void Question3()
    {
        currentGameState = GameState.Q3State;
        ShowScreen(Q3);
    }
    public void Question4()
    {
        currentGameState = GameState.Q4State;
        ShowScreen(Q4);
    }
    public void No()
    {
        currentGameState = GameState.IncorrectState;
        ShowScreen(Incorrect);
    }



    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}