using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COLLECTIBLE_MANAGER : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;

    public Text cube_txt;
    public int counter=0;
    public int d = 0;
    //int r = 0;
    string alphabets = "()xm9";
    string al = "xm9";
    public string b;
    public string myString;
    public string mString;
    int charAmount;
    string[] a;

  //  int gr = 0;
    void Start()
    {
        counter = 0;
        d = 0;
        int n = 6;
        printParentheses(n);
        a = b.Split(',');
        GenrateRandomString();

    }



   


    private static bool IsMatchingPair(char character1, char character2)
    {
        return character1 == '(' && character2 == ')';
    }
    private bool AreParenthesisBalanced(string exp)
    {
        var stack = new Stack<char>();

        for (int i = 0; i < exp.Length; i++)
        {
            switch (exp[i])
            {
                case '(':
                    stack.Push(exp[i]);
                    break;
                case ')' when stack.Count == 0:
                case ')' when !IsMatchingPair(stack.Pop(), exp[i]):
                    return false;
            }

        }
        return stack.Count == 0;
    }


    public void GenrateRandomString()
    {

        if (GameObject.Find("PLAYER").GetComponent<PLAYER_CONTROLLER>().PALINDROMES_TOTAL < 13)
        {
            GameObject.Find("PLAYER").GetComponent<PLAYER_CONTROLLER>().PALINDROMES_TOTAL++;
            generate(a);
            cube.tag = "collectible";
            Debug.Log(GameObject.Find("PLAYER").GetComponent<PLAYER_CONTROLLER>().PALINDROMES_TOTAL);
        }
        else
        {
            charAmount = Random.Range(9, 15);
            for (int i = 0; i <= charAmount; i++)
            {
                myString += alphabets[Random.Range(0, alphabets.Length)];

            }


            if (AreParenthesisBalanced(myString))
            {

                myString = myString + '(';
                cube.tag = "notcollectible";

            }
            else
            {

                // counter++;
                cube.tag = "notcollectible";

            }

            //if (GameObject.Find("PLAYER").GetComponent<PLAYER_CONTROLLER>().PALINDROMES_TOTAL < 13)
            //{
            //    if (counter >= 13)
            //    {
            //        generate(a);
            //        counter++;
            //        cube.tag = "collectible";
            //        GameObject.Find("PLAYER").GetComponent<PLAYER_CONTROLLER>().PALINDROMES_TOTAL++;
            //    }

            //    else
            //    {
            //        GenrateRandomString();
            //    }

            //}


        }

    }

    // Update is called once per frame
    void Update()
    {
        //counter++;
        cube_txt.text = myString;

      
    }



    public  void Validparentheses(int openP, int closeP, string a)
    {
        if (openP == 0 && closeP == 0)
            b = b + a + ',';
        if (openP > closeP)
            return;
        if (openP > 0)
            Validparentheses(openP - 1, closeP, a + "(");
        if (closeP > 0)
            Validparentheses(openP, closeP - 1, a + ")");


    }
    public  void printParentheses(int n)
    {
        Validparentheses(n / 2, n / 2, "");
        // Console.WriteLine(b);

    }
    public void generate(string[] s)
    {
    
        int t = Random.Range(3, 10);
        myString = "";

        int i;
        for (i = 0; i <= t; i++)
        {
            if (d == 0)
            {
                if (i < s[0].Length)
                    myString = myString + al[Random.Range(0, al.Length)] + s[0][i];
            }
            else if (d == 1)
            {
                if (i < s[1].Length)
                    myString = myString + al[Random.Range(0, al.Length)] + s[1][i];
            }
            else if (d == 2)
            {
                if (i < s[2].Length)
                    myString = myString + al[Random.Range(0, al.Length)] + s[2][i];
            }
            else if (d == 3)
            {
                if (i < s[3].Length)
                    myString = myString + al[Random.Range(0, al.Length)] + s[3][i];
            }
            else if (d == 4)
            {
                if (i < s[4].Length)
                    myString = myString + al[Random.Range(0, al.Length)] + s[4][i];
            }
            else if (d == 5)
            {
                if (i < s[5].Length)
                    myString = myString + al[Random.Range(0, al.Length)] + s[5][i];
            }
            else

                myString = myString + al[Random.Range(0, al.Length)];
        }

        if (i < s[d].Length) { 
        for (; i < s[d].Length; i++)
           myString += s[d][i];
        }
        //Debug.Log(myString);
     
        d++;
       
    }

}
