using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class AttemptsKeeper : MonoBehaviour
{
    public int numAttempts;
    Text attemptsText;
    
    void Start()
    {
        attemptsText = GetComponent<Text>();
        attemptsText.text = "Attempts: " + numAttempts.ToString();
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void AddAttempt()
    {
        numAttempts++;
        attemptsText.text = "Attempts: " + numAttempts.ToString();
    }
}
