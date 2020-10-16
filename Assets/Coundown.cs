using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coundown : MonoBehaviour
{
    public TextMeshProUGUI Text;
    
    public void SetThree()
    {
        Text.text = "3";
    }

    public void SetTwo()
    {
        Text.text = "2";
    }

    public void SetOne()
    {
        Text.text = "1";
    }

    public void SetStart()
    {
        Text.text = "GO!";
    }
}
