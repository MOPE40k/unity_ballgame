using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private GameObject congrats;
    void Start()
    {
        Congrats(false);
    }
    void OnTriggerStay()
    {
        Congrats(true);
        Invoke("NextLvl", 3f);
    }
    void NextLvl()
    {
        print("NextLevel");
    }
    void Congrats(bool textControl)
    {
        congrats.SetActive(textControl);
    }
}