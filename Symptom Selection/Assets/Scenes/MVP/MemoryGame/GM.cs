using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    [SerializeField]
    private Sprite bgImage;

    public Sprite[] puzzles;

    public List<Sprite> gamePuzzles = new List<Sprite>();

    public List<Button> btns = new List<Button>();

    private bool firstGuess, secondGuess;

    private int CountGuesses;
    private int CountCorrectGuesses;
    private int GameGuesses;

    private int firstGuessIndex, secondGuessIndex;

    private string firstGuessPuzzle, secondGuessPuzzle;

    //void Awake()
    //{
    //    puzzles = Resources.LoadAll<Sprite>("Sprite/abcxyz");
    //
    //}

    void Start()
    {
        GetButtons();
        AddListener();
        AddGamePuzzles();
        Shuffle(gamePuzzles);
        GameGuesses = gamePuzzles.Count / 2;
    }

    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for (int i = 0; i < objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
        }
    }
    void AddGamePuzzles()
    {
        int looper = btns.Count; // get button count
        int index = 0;

        for (int i = 0; i <looper; i++) //looping button
        {
            if (index == looper / 2)
            {
                index = 0; // reset button to 0
            }

            gamePuzzles.Add(puzzles[index]);

            index++;
        }
    }
    void AddListener()
    {
        foreach(Button btn in btns)
        {
            btn.onClick.AddListener(() => PickAPuzze()); // add the listener to the button
        }

    }
    public void PickAPuzze() // controlling the game
    {
        //string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name; 

        if (!firstGuess)
        {
            firstGuess = true;

            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name); //define which button we r clicking

            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name; //compare the name

            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
        }
        else if (!secondGuess)
        {
            secondGuess = true;

            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name); //define which button we r clicking

            secondGuessPuzzle = gamePuzzles[secondGuessIndex].name; //compare the name

            btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];

            CountGuesses++;

            StartCoroutine(CheckIfThePuzzleMatch());
        }
    }

        IEnumerator CheckIfThePuzzleMatch() // ienumerator creates a pause for the game
        {
            yield return new WaitForSeconds(1f); // make a pause

            if(firstGuessPuzzle == secondGuessPuzzle)
            {
                yield return new WaitForSeconds(0.5f);

                btns[firstGuessIndex].interactable = false;  // can't touch if u get it correct
                btns[secondGuessIndex].interactable = false;

                btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0); //make correct button disappear
                btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);

                CheckIfTheGameIsFinished();
            }
            else
            {
                btns[firstGuessIndex].image.sprite = bgImage;
                btns[secondGuessIndex].image.sprite = bgImage;
            }
            yield return new WaitForSeconds(0.5f); // change it to WaitUntil for matching the name of the disease

            firstGuess = secondGuess = false;
        }
        void CheckIfTheGameIsFinished()
        {
            CountCorrectGuesses++;
            if(CountCorrectGuesses == GameGuesses)
            {
                Debug.Log("Finished");
                Debug.Log("Take " + CountGuesses + " guess(es)");
            }
        }
        void Shuffle(List<Sprite> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Sprite temp = list[i];
                int randomIndex = Random.Range(i, list.Count);
                list[i] = list[randomIndex];
                list[randomIndex] = temp;
            }
        }

    }
    

