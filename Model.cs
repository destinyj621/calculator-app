using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CalculatorModel : MonoBehaviour
{
    
    public CalculatorView view;
    private string currentInput;
    private double result;
    private string currentOperation;
    private string operation;
    private double num;

    private bool isAlreadyCalculated = false;

    //clear
    public void clear(){
        currentInput = "";
        result = 0;
        currentOperation = "";
    }

    //adds number and decimal to the end of the number
    public void appendInput(string input){
        if (!(input == "." && currentInput.Contains(".")) && !(input == "%")) //if the input is a decimal point and there is already a decimal point, don't add another
            currentInput += input;
    }
    
    //sets the operation to +, -, *, and /
    public void setOperation(string operation){
        currentOperation = operation;
        result = double.Parse(currentInput);
        currentInput = "";
    }

    public void setIsCalculatedTrue(){
        isAlreadyCalculated = true;
    }

    public void setIsCalculatedFalse(){
        isAlreadyCalculated = false;
    }

    public bool getIsCalculated(){
        return isAlreadyCalculated;
    }

    public string getCurrentInput(){
       return currentInput;
    } 

    public void setCurrentInput(double num){
        currentInput = num.ToString();
    }

    //preforms addition, subtraction, multiplication, division, and percent, and returns the value
    public double calculate(){
        num = double.Parse(currentInput);

        if (currentOperation == "+")
            result += num;
        else if (currentOperation == "-")
            result -= num;
        else if (currentOperation == "*")
            result *= num;
        else if (currentOperation == "/")
                result /= num;

        setCurrentInput(result);
        return result;
    }

     //changes the sign of the result and returns the value
    public double changeSign(){
        double num = double.Parse(getCurrentInput());
        num *= -1;
        setCurrentInput(num);
        return num;
    }

    //calculates the percentage of the currentInput
    public double percentage(){
        num = double.Parse(currentInput);
        result = (num / 100);
        
        setCurrentInput(result);
    
        return result;
    }

}