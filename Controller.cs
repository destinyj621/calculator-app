using UnityEngine;


public class CalculatorController : MonoBehaviour
{
    public CalculatorModel model;
    public CalculatorView view;


    void Start(){
        model = new CalculatorModel();
        view.updateDisplay("0"); //when first turned on, text shows 0
    }


    public void clear(){
        model.clear();
        model.setIsCalculatedFalse();
        view.updateDisplay("0"); //after the previous logic is cleared, the text shows 0
    }

    public void numPressed(string num){//for nums 0-9 and .
        if (model.getIsCalculated()){
            model.clear();
            model.setIsCalculatedFalse();
        }
        
        model.appendInput(num);
        view.updateDisplay(model.getCurrentInput()); //shows the last number pressed
    }

    public void operationPressed(string operation){
        model.setIsCalculatedFalse();
        model.setOperation(operation); //for +, -, *, and /
    }

    public void equalPressed(){ //for =
        model.setIsCalculatedTrue();
        if (model.getCurrentInput()!="0")
            view.updateDisplay(model.calculate().ToString()); //calculates expression, converts to a string, and prints
        else
            view.updateDisplay("Error");
    }

    public void signPressed(){ //for +/-
        view.updateDisplay(model.changeSign().ToString()); //changes sign, converts to a string, and prints
    }

    public void percentagePressed(){
        view.updateDisplay(model.percentage().ToString()); //calculates percentage, converts to a string, and prints
    }
}

