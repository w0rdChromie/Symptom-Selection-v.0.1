using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckScore : MonoBehaviour
{
    
    public Vector3 rightpos;
    public bool correct;
    RectTransform SS;
    public Text checkcorrect;
    public List<Vector3> anchorP = new List<Vector3>();
    DragDrop dragScript;

    // Start is called before the first frame update
    void Start()
    {
        SS = GetComponent<RectTransform>();
        correct = false;
        dragScript = GetComponent<DragDrop>();
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(dragScript.canDrag);
    }
    public void IsAnchor()
    {
        for (int i = 0; i<anchorP.Count; i++)
        {
            if ( SS.localPosition == anchorP[i])
            {
                dragScript.canDrag = false;
               
            }
        }
    }
    public void CheckC()
    {
        if (SS.localPosition == rightpos)
        {
            correct = true;
            checkcorrect.text = "Correct";
            checkcorrect.GetComponent<Text>().color = Color.green;
        }
        else
        {
            correct = false;
            checkcorrect.text = "Incorrect";
            checkcorrect.GetComponent<Text>().color = Color.red;
        }
    }
}
