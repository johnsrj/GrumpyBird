﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int hi;
    // Start is called before the first frame update
    void Start()
    {
        hi = PlayerPrefs.GetInt("highscore");   
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
