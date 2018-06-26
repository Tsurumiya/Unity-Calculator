using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

    public Text display;

    float number0;
    float number1;
    float result;

    int pointcheck = 0;
    int numbercheck = 0;
    int calcheck = 0;

    public AudioSource Audio;

    // Use this for initialization
    void Start () {
        Audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NumberClick (int number)
    {
        if (numbercheck == 0)
        {
            if (display.text == "0")
            {
                display.text = number.ToString();
                number0 = Single.Parse(display.text);
                Debug.Log(number0);
            }
            else
            {
                display.text += number.ToString();
                number0 = Single.Parse(display.text);
                Debug.Log(number0);
            }
        }

        if (numbercheck == 1)
        {
            display.text = number.ToString();
            number0 = Single.Parse(display.text);
            Debug.Log(number0);
            numbercheck = 0;
        }
    }

    public void PointClick ()
    {
        pointcheck += 1;
        if (numbercheck == 0)
        {
            if (pointcheck == 1)
            {
                display.text += ".";
                number0 = Single.Parse(display.text);
                Debug.Log(number0);
            }
        }

        if (numbercheck == 1)
        {
            display.text = "0.";
            number0 = Single.Parse(display.text);
            Debug.Log(number0);
            numbercheck = 0;
        }

    }

    public void PlusMinusClick()
    {
        if (numbercheck == 0)
        {
            number0 = -number0;
            display.text = number0.ToString();
            Debug.Log(number0);
        }
        if (numbercheck == 1)
        {
            number1 = -number1;
            display.text = number1.ToString();
            Debug.Log(number1);
        }
    }

    public void AddClick ()
    {
        Calculate();
        calcheck = 1;
        Debug.Log("+");
    }

    public void SubstractClick()
    {
        Calculate();
        calcheck = 2;
        Debug.Log("-");
    }

    public void MultiplyClick()
    {
        Calculate();
        calcheck = 3;
        Debug.Log("×");
    }

    public void DivideClick()
    {
        Calculate();
        calcheck = 4;
        Debug.Log("÷");
    }

    public void EqualClick()
    {
        Calculate();
        calcheck = 0;
        Debug.Log("=");
    }

    public void AllClearClick()
    {
        display.text = "0";
        number0 = 0;
        number1 = 0;
        numbercheck = 0;
        pointcheck = 0;
        calcheck = 0;

        Debug.Log("AC");
    }

    public void ClearClick()
    {
        display.text = "0";
        number0 = 0;

        Debug.Log("C");
    }

    void Calculate()
    {
        if (numbercheck == 0)
        {
            numbercheck = 1;

            if (calcheck == 0)
            {
                number1 = number0;
            }

            else
            {
                
                if (calcheck == 1)
                {
                    number1 = number1 + number0;
                }

                if (calcheck == 2)
                {
                    number1 = number1 - number0;
                }

                if (calcheck == 3)
                {
                    number1 = number1 * number0;
                }

                if (calcheck == 4)
                {
                    number1 = number1 / number0;
                }

                display.text = number1.ToString();
                number0 = 0;
                pointcheck = 0;
            }
        }
    }
}
