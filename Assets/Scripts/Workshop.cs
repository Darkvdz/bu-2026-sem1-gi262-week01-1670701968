using UnityEngine;

public class Workshop : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        As01_SyntaxIf();
        As02_StringComparisonExample();
        As03_NumberComparisonExample();
        As04_AndOrOperatorExample();
        As05_GuessingNumberExample();
        As06_GuessingNumberMoreOrLessExample();
        As07_VerifyIdentityExample();
    }

    public bool isSixOClock;
    public void As01_SyntaxIf()
    {
        if (isSixOClock)
        {
            Debug.Log("The Door Open");
        }
        Debug.Log("Knock Knock!");
        
    }

    public string password;
    public void As02_StringComparisonExample()
    {
        if (password != "Moon")
        {
            Debug.Log("Wrong Password");
        }
        if (password == "Moon")
        {
            Debug.Log("Password is Correct");
        }
    }

    public int as03Number;
    public void As03_NumberComparisonExample()
    {
        if(as03Number > 10)
        {
            Debug.Log("My Number > 10");
        }

        if (as03Number < 10)
        {
            Debug.Log("My Number < 10");
        }

        if (as03Number == 10)
        {
            Debug.Log("My Number == 10");
        }

        if (as03Number >= 10)
        {
            Debug.Log("My Number >= 10");
        }

        if (as03Number <= 10)
        {
            Debug.Log("My Number <= 10");
        }

        if (as03Number != 10)
        {
            Debug.Log("My Number != 10");
        }
    }

    public int as04Number;
    public void As04_AndOrOperatorExample()
    {
        if( as04Number > 8 && as04Number < 12)
        {
            Debug.Log ("My number 8 > < 12");
        }

        if (as04Number > 8 || as04Number < 12)
        {
            Debug.Log("My number or 8 || 12");
        }

    }

    public int as05GuessingNumber;
    public int as05RandomNumber;
    public void As05_GuessingNumberExample()
    {
        Debug.Log($"Guessing number {as05RandomNumber}");

        if(as05GuessingNumber == as05RandomNumber)
        {
            Debug.Log("Congratulations! You guessed the correct number.");
        }

        //if (as05GuessingNumber != as05RandomNumber) // This is Posible to Mistake
        //{
        //    Debug.Log("I guess we can just agree to disagree.");
        //}

        else
        {
            Debug.Log("I guess we can just agree to disagree.");
        }
    }

    public int as06GuessingNumber;
    public int as06RandomNumber;
    public void As06_GuessingNumberMoreOrLessExample()
    {
        Debug.Log($"Guessing number {as06RandomNumber}");

        if (as06GuessingNumber < as06RandomNumber)
        {
            Debug.Log("Too low! Try again.");
        }

        else if (as06GuessingNumber > as06RandomNumber)
        {
            Debug.Log("Too high! Try again.");
        }

        else
        {
            Debug.Log("Congratulations! We are same mind.");
        }
    }

    public string as07Username;
    public string as07Password;
    public int as07Age;
    public bool as07IsPaid;
    public void As07_VerifyIdentityExample()
    {
        if (as07Username == "user" && as07Password == "user123")
        {
            Debug.Log("You have user access.");

            if (as07IsPaid)
            {
                Debug.Log("Welcome VIP Member.");
            }

            else
            {
                Debug.Log("Welcome free Member.");
            }

            if (as07Age > 18)
            {
                Debug.Log("You have access to exclusive content");
            }
        }

        else
        {
            Debug.Log("You have guest access.");
        }
    }
}
