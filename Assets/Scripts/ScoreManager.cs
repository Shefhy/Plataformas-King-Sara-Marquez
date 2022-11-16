using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
//using UnityEngine.UI;

public class ScoreManager : MonoBehaviour

//https://www.youtube.com/watch?v=DZ-3g31jk90

{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;
    public GameObject Victory;
    
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

public void ChangeScore(int coinValue)
{
    score += coinValue;
    text.text = "X" + score.ToString();

    if(score >= 3)
        {
            Victory.SetActive(true);
        }
    
}
}