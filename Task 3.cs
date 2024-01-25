using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    //initialize variable
    [SerializeField] int amountPaid;
    void Start()
    {
        cashDistribution(amountPaid);
    }

    private void cashDistribution(int amount)
    {
        //use modulus function to determine how to split the cash distributions
        int hundreds = amount / 100;
        int fifties = (amount % 100) / 50;
        int twenties = (amount % 50) / 20;
        int tens = (amount % 20) / 10;
        int fives = (amount % 10) / 5;
        int ones = (amount % 5);

        //print out all of the values to the command prompt
        Debug.Log("Num of $100: " + hundreds + " Num of $50: " + fifties +
            " Num of $20: " + twenties + " Num of $10: " + tens + " Num of $5: " + fives
            + " Num of $1: " + ones);
    }

}
