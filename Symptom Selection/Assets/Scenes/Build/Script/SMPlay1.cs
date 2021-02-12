using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SMPlay1 : MonoBehaviour
{

    public enum GameState { K1State, K2State, K3State, K4State, K5State, ScoreState };
    public GameState currentGameState;

    public GameObject K1;
    public GameObject K2;
    public GameObject K3;
    public GameObject K4;
    public GameObject K5;
    public GameObject Score;

    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;
    public Text TextFinal;
    public Text Checkcheck;

    public Button b1c;
    public Button b1i1;
    public Button b1i2;
    public Button b1i3;

    public Button b2c;
    public Button b2i1;
    public Button b2i2;
    public Button b2i3;

    public Button b3c;
    public Button b3i1;
    public Button b3i2;
    public Button b3i3;

    public Button b4c;
    public Button b4i1;
    public Button b4i2;
    public Button b4i3;

    public Text HiText;
    public string PN1;
    int S;
    public AudioClip CorrectSound, IncorrectSound;
    private AudioSource audioSource;



    // Use this for initialization
    void Awake()
    {
        PN1 = PlayerPrefs.GetString("PN");
    }
    void Start()
    {
        currentGameState = GameState.K1State;
        ShowScreen(K1);
        S = 0;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        FinalScore();
        HiText.text = "Hello " + PN1 + ", This quiz will test your knowledge of certain dermatological conditions.  Each correct answer will add 25 points to your total score. The optimal score is 100 points. Good Luck!";

    }

    void ShowScreen(GameObject gameObjectToShow)
    {

        K1.SetActive(false);
        K2.SetActive(false);
        K3.SetActive(false);
        K4.SetActive(false);
        K5.SetActive(false);
        Score.SetActive(false);
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
    public void CheckScore()
    {
        currentGameState = GameState.ScoreState;
        ShowScreen(Score);
    }
    public void Play()
    {
        SceneManager.LoadScene("Play2");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void Correct()
    {
        if (currentGameState == GameState.K2State)
        {
            Text1.text = "Correct! Nice Job!";
            S = S + 25;
            audioSource.PlayOneShot(CorrectSound);
            b1c.GetComponent<Image>().color = Color.green;
            Text1.GetComponent<Text>().color = Color.green;
            b1c.GetComponent<Button>().interactable = false;
            b1i1.GetComponent<Button>().interactable = false;
            b1i2.GetComponent<Button>().interactable = false;
            b1i3.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K3State)
        {
            Text2.text = "Correct! Nice Job!";
            S = S + 25;
            audioSource.PlayOneShot(CorrectSound);
            b2c.GetComponent<Image>().color = Color.green;
            Text2.GetComponent<Text>().color = Color.green;
            b2c.GetComponent<Button>().interactable = false;
            b2i1.GetComponent<Button>().interactable = false;
            b2i2.GetComponent<Button>().interactable = false;
            b2i3.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K4State)
        {
            Text3.text = "Correct! Nice Job!";
            S = S + 25;
            audioSource.PlayOneShot(CorrectSound);
            b3c.GetComponent<Image>().color = Color.green;
            Text3.GetComponent<Text>().color = Color.green;
            b3c.GetComponent<Button>().interactable = false;
            b3i1.GetComponent<Button>().interactable = false;
            b3i2.GetComponent<Button>().interactable = false;
            b3i3.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K5State)
        {
            Text4.text = "Correct! Nice Job!";
            S = S + 25;
            audioSource.PlayOneShot(CorrectSound);
            b4c.GetComponent<Image>().color = Color.green;
            Text4.GetComponent<Text>().color = Color.green;
            b4c.GetComponent<Button>().interactable = false;
            b4i1.GetComponent<Button>().interactable = false;
            b4i2.GetComponent<Button>().interactable = false;
            b4i3.GetComponent<Button>().interactable = false;
        }

    }
    public void Incorrect1()
    {
        if (currentGameState == GameState.K2State)
        {
            Text1.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b1i1.GetComponent<Image>().color = Color.red;
            b1i1.GetComponent<Button>().interactable = false;
            Text1.GetComponent<Text>().color = Color.red;
            b1c.GetComponent<Button>().interactable = false;
            b1c.GetComponent<Image>().color = Color.green;
            b1i2.GetComponent<Button>().interactable = false;
            b1i3.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K3State)
        {
            Text2.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b2i1.GetComponent<Image>().color = Color.red;
            b2i1.GetComponent<Button>().interactable = false;
            Text2.GetComponent<Text>().color = Color.red;
            b2c.GetComponent<Button>().interactable = false;
            b2c.GetComponent<Image>().color = Color.green;
            b2i2.GetComponent<Button>().interactable = false;
            b2i3.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K4State)
        {
            Text3.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b3i1.GetComponent<Image>().color = Color.red;
            b3i1.GetComponent<Button>().interactable = false;
            Text3.GetComponent<Text>().color = Color.red;
            b3c.GetComponent<Button>().interactable = false;
            b3c.GetComponent<Image>().color = Color.green;
            b3i2.GetComponent<Button>().interactable = false;
            b3i3.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K5State)
        {
            Text4.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b4i1.GetComponent<Image>().color = Color.red;
            b4i1.GetComponent<Button>().interactable = false;
            Text4.GetComponent<Text>().color = Color.red;
            b4c.GetComponent<Button>().interactable = false;
            b4c.GetComponent<Image>().color = Color.green;
            b4i2.GetComponent<Button>().interactable = false;
            b4i3.GetComponent<Button>().interactable = false;
        }
    }
    public void Incorrect2()
    {
        if (currentGameState == GameState.K2State)
        {
            Text1.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b1i2.GetComponent<Image>().color = Color.red;
            b1i2.GetComponent<Button>().interactable = false;
            Text1.GetComponent<Text>().color = Color.red;
            b1c.GetComponent<Button>().interactable = false;
            b1c.GetComponent<Image>().color = Color.green;
            b1i1.GetComponent<Button>().interactable = false;
            b1i3.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K3State)
        {
            Text2.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b2i2.GetComponent<Image>().color = Color.red;
            b2i2.GetComponent<Button>().interactable = false;
            Text2.GetComponent<Text>().color = Color.red;
            b2c.GetComponent<Button>().interactable = false;
            b2c.GetComponent<Image>().color = Color.green;
            b2i1.GetComponent<Button>().interactable = false;
            b2i3.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K4State)
        {
            Text3.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b3i2.GetComponent<Image>().color = Color.red;
            b3i2.GetComponent<Button>().interactable = false;
            Text3.GetComponent<Text>().color = Color.red;
            b3c.GetComponent<Button>().interactable = false;
            b3c.GetComponent<Image>().color = Color.green;
            b3i1.GetComponent<Button>().interactable = false;
            b3i3.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K5State)
        {
            Text4.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b4i2.GetComponent<Image>().color = Color.red;
            b4i2.GetComponent<Button>().interactable = false;
            Text4.GetComponent<Text>().color = Color.red;
            b4c.GetComponent<Button>().interactable = false;
            b4c.GetComponent<Image>().color = Color.green;
            b4i1.GetComponent<Button>().interactable = false;
            b4i3.GetComponent<Button>().interactable = false;
        }
    }
    public void Incorrect3()
    {
        if (currentGameState == GameState.K2State)
        {
            Text1.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b1i3.GetComponent<Image>().color = Color.red;
            b1i3.GetComponent<Button>().interactable = false;
            Text1.GetComponent<Text>().color = Color.red;
            b1c.GetComponent<Button>().interactable = false;
            b1c.GetComponent<Image>().color = Color.green;
            b1i2.GetComponent<Button>().interactable = false;
            b1i1.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K3State)
        {
            Text2.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b2i3.GetComponent<Image>().color = Color.red;
            b2i3.GetComponent<Button>().interactable = false;
            Text2.GetComponent<Text>().color = Color.red;
            b2c.GetComponent<Button>().interactable = false;
            b2c.GetComponent<Image>().color = Color.green;
            b2i2.GetComponent<Button>().interactable = false;
            b2i1.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K4State)
        {
            Text3.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b3i3.GetComponent<Image>().color = Color.red;
            b3i3.GetComponent<Button>().interactable = false;
            Text3.GetComponent<Text>().color = Color.red;
            b3c.GetComponent<Button>().interactable = false;
            b3c.GetComponent<Image>().color = Color.green;
            b3i2.GetComponent<Button>().interactable = false;
            b3i1.GetComponent<Button>().interactable = false;
        }
        if (currentGameState == GameState.K5State)
        {
            Text4.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b4i3.GetComponent<Image>().color = Color.red;
            b4i3.GetComponent<Button>().interactable = false;
            Text4.GetComponent<Text>().color = Color.red;
            b4c.GetComponent<Button>().interactable = false;
            b4c.GetComponent<Image>().color = Color.green;
            b4i2.GetComponent<Button>().interactable = false;
            b4i1.GetComponent<Button>().interactable = false;
        }
    }

    public void FinalScore()
    {
        TextFinal.text = "Your Score is " + S;
        if (S <= 0)
        {
            Checkcheck.text = "Go back to the books...";
        }
        else if (S == 25)
        {
            Checkcheck.text = "Why don't you go study a bit more...";
        }
        else if (S == 50)
        {
            Checkcheck.text = "You're halfway there...";
        }
        else if (S == 75)
        {
            Checkcheck.text = "Almost...";
        }
        else if (S == 100)
        {
            Checkcheck.text = "Very good!  Looks like you know your stuff...";
        }

    }
}