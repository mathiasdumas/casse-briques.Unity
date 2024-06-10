using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public GameObject VictoryText;
    

    public void CheckVictory()
    {
        if (transform.childCount == 1)
        {
            VictoryText.SetActive(true);
        }
    }
}
