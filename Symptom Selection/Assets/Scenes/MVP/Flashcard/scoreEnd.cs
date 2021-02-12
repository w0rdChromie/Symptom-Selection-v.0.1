using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreEnd : MonoBehaviour
{
    public Text Score;
    public Text Say;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = gameManagement.totalScore.ToString() + " / 4";

        if(gameManagement.totalScore == 1)
        {
            Say.text = "Please study!";
        }
        if (gameManagement.totalScore == 2)
        {
            Say.text = "Not too bad";
        }
        if (gameManagement.totalScore == 3)
        {
            Say.text = "Hey, it's pretty good";
        }
        if (gameManagement.totalScore == 4)
        {
            Say.text = "Wonderful";
        }
    }
    public void Play2()
    {
        SceneManager.LoadScene("Play2");
    }
}
