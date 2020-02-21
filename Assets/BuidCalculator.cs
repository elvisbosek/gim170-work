using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuidCalculator : MonoBehaviour
{

    string customerNameA = "Paul";
    string customerNameB = "Penelope";

    float steakAndChips = 15.5f;
    float burgerWithLot = 12f;
    float nachos = 5.5f;
    float beer = 8.05f;
    float wine = 4.95f;
    float coke = 9f;

    float customerATotal;
    float customerBTotal;


    // Start is called before the first frame update
    void Start()
    {
        print("the first customer is " + customerNameA + "and the second customer is " + customerNameB);


        //code goes here to calculate totals for customerA And B
        customerATotal = burgerWithLot + beer + wine + (0.5f * nachos);
        customerBTotal = steakAndChips + coke + wine + (nachos / 2);

        // waiter wants 50/50 
        float completeTotal = customerATotal + customerBTotal;

        print("the waiter would prefer each customer pay $" + (completeTotal / 2));


        // paul wants 100% /0%

        print(customerNameA + " wants to pay " + completeTotal);


        //penelope wants each of them to pay for their own items
        print("the total amount for " + customerNameA + "is " + customerATotal + "the total amount for" + customerNameB + "is" + customerBTotal);
        

        //So we shall average these all out!
        //Paul's items, plus half of the total (the waiter's suggestion), plus ALL of it (what paul wanted to pay) - divided by 3 (the number of options)
        //Penelope's result will be whatever remains from the total after this value is subtracted.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
