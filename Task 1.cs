using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    //Create all of the variables for the course difficulty
    [SerializeField] private int numOfModules;
    [SerializeField] private int numOfReadings;
    [SerializeField] private int numOfQuizzes;
    [SerializeField] private int numOfAssignments;
    [SerializeField] private bool hasProfTaught;

    private string challengeScore;
    
    void Start()
    {
        challengeScore = calcTotalDifficulty();

        Debug.Log("Course Difficulty = " + challengeScore);
    }

    //Calculate the module difficulty (15%)
    private float calcModuleDifficulty()
    {
        float moduleDifficulty = (float)(numOfModules * .15);

        return moduleDifficulty;
    }

    //Calculate the readings difficulty (30%)
    private float calcReadingsDifficulty()
    {
        float readingDifficulty = (float)(numOfReadings * .3);

        return readingDifficulty;
    }

    //Calculate the quizzes difficulty (15%)
    private float calcQuizDifficulty()
    {
        float quizDifficulty = (float)(numOfQuizzes * .15);

        return quizDifficulty;
    }

    //Calculate the assignment difficulty (30%)
    private float calcAssignmentDifficulty()
    {
        float assignmentDifficulty = (float)(numOfAssignments * .3);

        return assignmentDifficulty;
    }

    //Combine the difficulties of the course together into one value
    private string calcTotalDifficulty()
    {
        float courseDifficulty;

        //Get all of the values from the functions above
        float quizDifficulty = calcQuizDifficulty();
        float moduleDifficulty = calcModuleDifficulty();
        float assignmentDifficulty = calcAssignmentDifficulty();
        float readingDifficulty = calcReadingsDifficulty();
        float profDifficulty;

        //If professor hasn't taught the course before, add another 10% difficulty
        if (hasProfTaught)
        {
            profDifficulty = 0;
        }
        else
        {
             profDifficulty = 1;
        }

        //Add the difficulties together
        courseDifficulty = quizDifficulty + moduleDifficulty 
            + assignmentDifficulty + readingDifficulty + profDifficulty;

        if(courseDifficulty < 1)
        {
            courseDifficulty = 1;
        }

        if(courseDifficulty > 10)
        {
            courseDifficulty = 10;
        }

        //return the course difficulty with 1 decimal
        return courseDifficulty.ToString("f1");
    }
}
