using UnityEngine;
using UnityEngine.UI;

public class CalculatorView : MonoBehaviour
{
    public Text displayText;  // Assign this in Unity's Inspector

    public void updateDisplay(string text)
    {

            displayText.text = text;  // Update the displayed text

    }
}
