using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyPartsBehaviour : MonoBehaviour
{
    public GameObject[] bodyParts;
    private Color[] colors = {Color.green , Color.blue};
    public Color defaultColor = Color.white;
    public bool isColored = false;
    public int score = 0;
    public Text scoreTxt;

    void CambioColore()
    {
        for(int i = 1; i < bodyParts.Length; i++)
        {
            bodyParts[(int)Random.Range(0, 4)].GetComponent<Renderer>().material.color = colors[(int)Random.Range(0, 2)];
        }

        isColored = true;
    }


    // Update is called once per frame
    void Update()
    {
        
        if (bodyParts[0].GetComponent<Renderer>().material.color == Color.white && bodyParts[1].GetComponent<Renderer>().material.color == Color.white && bodyParts[2].GetComponent<Renderer>().material.color == Color.white && bodyParts[3].GetComponent<Renderer>().material.color == Color.white)
        {
            isColored = false;
        }

        if (!isColored)
        {
            CambioColore();
        }

        print(ScoreManager.score);
        scoreTxt.text = "Score: " + ScoreManager.score.ToString();
    }
}
