using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagecon : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagement.loadQuestion == "Y") // make the choices are correct with the order
        {
            if (gameManagement.textPointer == 1)
            {
                GetComponent<SpriteRenderer>().sprite = image1;
            }
            if (gameManagement.textPointer == 2)
            {
                GetComponent<SpriteRenderer>().sprite = image2;
            }
            if (gameManagement.textPointer == 3)
            {
                GetComponent<SpriteRenderer>().sprite = image3;
            }
            if (gameManagement.textPointer == 4)
            {
                GetComponent<SpriteRenderer>().sprite = image4;
            }
        }

    }
    void OnMouseDown()
    {
        gameManagement.playerClicked = "Y";
        gameManagement.currentSelection = gameObject.name;
        Debug.Log(gameObject.name);
    }

    
}
