using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    //initialize the variables that
    [SerializeField] float coverPrice;
    [SerializeField] float numOfOrders;

    private float shopDiscount = .4f;
    private int firstShippingFee = 3;
    private float bulkShippingFee = .75f;

    private float totalCost;

    void Start()
    {
        Debug.Log("Total wholesale cost = " + calculateShippingCosts());
    }

    private float calculateShippingCosts()
    {
        //initialize the local variables
        float shippingFee;
        float bookPrice = coverPrice * shopDiscount * numOfOrders;

        //if there is only one order, do not add bulk shipping cost
        if(numOfOrders == 1)
        {
            shippingFee = firstShippingFee;
        }
        else
        {
            shippingFee = firstShippingFee + ((numOfOrders - 1) * bulkShippingFee);
        }
        
        totalCost = bookPrice + shippingFee;

        return totalCost;
    }
}
