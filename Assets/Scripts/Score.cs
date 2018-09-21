using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    //Public variables visible in Unity
    public TextMesh displayText;

    //private variables can't be touched by other scripts
    private int currentValue = 0;
    
    //update both the data value And the visual display
    public void ChangeValue(int _toChange)
    {
        currentValue = currentValue + _toChange;
        displayText.text = currentValue.ToString();
    }

    //reset the score to zero
    public void ResetScore()
    {
        currentValue = 0;
        displayText.text = currentValue.ToString();
    }
}
