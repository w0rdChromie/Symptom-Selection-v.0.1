using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SM : MonoBehaviour
{

    public enum GameState { MenuState, K1State, K2State, K3State, K4State };
    public GameState currentGameState;

    public GameObject Menu;
    public GameObject K1;
    public GameObject K2;
    public GameObject K3;
    public GameObject K4;
    public InputField pName;


    public string PlayerName;
    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;
    public Text tellPlayerHi;

    // Use this for initialization
    void Start()
    {
        currentGameState = GameState.MenuState;
        ShowScreen(Menu);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        Menu.SetActive(false);
        K1.SetActive(false);
        K2.SetActive(false);
        K3.SetActive(false);
        K4.SetActive(false);

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
    public void Play()
    {
        SceneManager.LoadScene("GameTest");
    }

    public void SetGetName()
    {

        PlayerName = pName.text;
        tellPlayerHi.text = "Hello Resident " + PlayerName + ", time to review your basic knowledge";
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}