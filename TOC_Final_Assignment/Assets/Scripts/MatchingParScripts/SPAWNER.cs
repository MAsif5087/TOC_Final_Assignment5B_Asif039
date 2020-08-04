using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SPAWNER : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject POS_1;
    public GameObject POS_2;
    public GameObject POS_3;
    public GameObject POS_4;
    public GameObject POS_5;
    public GameObject POS_6;
    public GameObject POS_7;
    public GameObject POS_8;
    public GameObject POS_9;
    public GameObject POS_10;
    public GameObject POS_11;
    public GameObject POS_12;
    public GameObject POS_13;
    public GameObject POS_14;
    public GameObject POS_15;
    public GameObject POS_16;
    public GameObject POS_17;
    public GameObject POS_18;
    public GameObject POS_19;
    public GameObject POS_20;
    public GameObject POS_21;
    public GameObject POS_22;
    public GameObject POS_23;
    public GameObject POS_24;
    public GameObject POS_25;
    public GameObject POS_26;
    public GameObject POS_27;
    public GameObject POS_28;
    public GameObject POS_29;
    public GameObject POS_30;
    public GameObject POS_31;
    public GameObject POS_32;
    public GameObject POS_33;
    public GameObject POS_34;
    public GameObject POS_35;
    public GameObject POS_36;
    public GameObject POS_37;
    public GameObject POS_38;
    public GameObject POS_39;
    public GameObject COLLECTIBLE_PREFAB;

    public int COLLECTIBLE_AMOUNT;


  //  public int RANDOM_CHECKER_1;
    //public int RANDOM_CHECKER_2;
    //public int RANDOM_CHECKER_3;
    //public int RANDOM_CHECKER_4;
    //public int RANDOM_CHECKER_5;

    public int RANDOM_POSITION;
    public int POSITIONFILLER;

    bool SPACE_CHECKER_1=true;
    bool SPACE_CHECKER_2 = true;
    bool SPACE_CHECKER_3 = true;
    bool SPACE_CHECKER_4 = true;
    bool SPACE_CHECKER_5 = true;
    bool SPACE_CHECKER_6 = true;
    bool SPACE_CHECKER_7 = true;
    bool SPACE_CHECKER_8 = true;
    bool SPACE_CHECKER_9 = true;
    bool SPACE_CHECKER_10 = true;
    bool SPACE_CHECKER_11 = true;
    bool SPACE_CHECKER_12 = true;
    bool SPACE_CHECKER_13 = true;
    bool SPACE_CHECKER_14 = true;
    bool SPACE_CHECKER_15 = true;
    bool SPACE_CHECKER_16 = true;
    bool SPACE_CHECKER_17 = true;
    bool SPACE_CHECKER_18 = true;
    bool SPACE_CHECKER_19 = true;
    bool SPACE_CHECKER_20 = true;
    bool SPACE_CHECKER_21 = true;
    bool SPACE_CHECKER_22 = true;
    bool SPACE_CHECKER_23 = true;
    bool SPACE_CHECKER_24 = true;
    bool SPACE_CHECKER_25 = true;
    bool SPACE_CHECKER_26 = true;
    bool SPACE_CHECKER_27 = true;
    bool SPACE_CHECKER_28 = true;
    bool SPACE_CHECKER_29 = true;
    bool SPACE_CHECKER_30 = true;
    bool SPACE_CHECKER_31 = true;
    bool SPACE_CHECKER_32 = true;
    bool SPACE_CHECKER_33 = true;
    bool SPACE_CHECKER_34 = true;
    bool SPACE_CHECKER_35 = true;
    bool SPACE_CHECKER_36 = true;
    bool SPACE_CHECKER_37 = true;
    bool SPACE_CHECKER_38 = true;
    bool SPACE_CHECKER_39 = true;
    GameObject PREFAB_1;
    GameObject PREFAB_2;
    GameObject PREFAB_3;
    GameObject PREFAB_4;
    GameObject PREFAB_5;
    GameObject PREFAB_6;
    GameObject PREFAB_7;
    GameObject PREFAB_8;
    GameObject PREFAB_9;
    GameObject PREFAB_10;
    GameObject PREFAB_11;
    GameObject PREFAB_12;
    GameObject PREFAB_13;
    GameObject PREFAB_14;
    GameObject PREFAB_15;
    GameObject PREFAB_16;
    GameObject PREFAB_17;
    GameObject PREFAB_18;
    GameObject PREFAB_19;
    GameObject PREFAB_20;
    GameObject PREFAB_21;
    GameObject PREFAB_22;
    GameObject PREFAB_23;
    GameObject PREFAB_24;
    GameObject PREFAB_25;
    GameObject PREFAB_26;
    GameObject PREFAB_27;
    GameObject PREFAB_28;
    GameObject PREFAB_29;
    GameObject PREFAB_30;
    GameObject PREFAB_31;
    GameObject PREFAB_32;
    GameObject PREFAB_33;
    GameObject PREFAB_34;
    GameObject PREFAB_35;
    GameObject PREFAB_36;
    GameObject PREFAB_37;
    GameObject PREFAB_38;
    GameObject PREFAB_39;
    void Start()
    {
        RANDOM_POSITION = -1;
        // InvokeRepeating("COLLECTIBLE_GENERATOR", 2.0f, 0.3f);
        COLLECTIBLE_GENERATOR();


    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

     void   COLLECTIBLE_GENERATOR()
    {
        Debug.Log("COLLECTIBLE_FUNCTIONS");
        InvokeRepeating("destroyprefabs",0.1f,0.3f);
       
    }

    private static bool IsMatchingPair(char character1, char character2)
    {
        return character1 == '(' && character2 == ')';
    }
    private bool AreParenthesisBalanced(IEnumerable<char> exp)
    {
        var stack = new Stack<char>();

        foreach (var c in exp)
        {
            switch (c)
            {
                case '(':
                    stack.Push(c);
                    break;
                case ')' when stack.Count == 0:
                case ')' when !IsMatchingPair(stack.Pop(), c):
                    return false;
            }
        }

        return stack.Count == 0;
    }
    void destroyprefabs()
    {
        Debug.Log("destroyprefabs");



        RANDOM_POSITION = Random.Range(1, 40);
        if (RANDOM_POSITION==1&&SPACE_CHECKER_1==true)
            {
                PREFAB_1 = Instantiate(COLLECTIBLE_PREFAB, POS_1.transform.position, POS_1.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_1 = false;

            }
            if (RANDOM_POSITION == 2 && SPACE_CHECKER_2 == true)
            {
                PREFAB_2 = Instantiate(COLLECTIBLE_PREFAB, POS_2.transform.position, POS_2.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_2 = false;

            }
            if (RANDOM_POSITION == 3 && SPACE_CHECKER_3 == true)
            {
                PREFAB_3 = Instantiate(COLLECTIBLE_PREFAB, POS_3.transform.position, POS_3.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_3 = false;

            }
            if (RANDOM_POSITION == 4 && SPACE_CHECKER_4 == true)
            {
                PREFAB_4 = Instantiate(COLLECTIBLE_PREFAB, POS_4.transform.position, POS_4.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_4 = false;

            }
            if (RANDOM_POSITION == 5 && SPACE_CHECKER_5 == true)
            {
                PREFAB_5 = Instantiate(COLLECTIBLE_PREFAB, POS_5.transform.position, POS_5.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_5 = false;

            }
            if (RANDOM_POSITION == 6 && SPACE_CHECKER_6 == true)
            {
                PREFAB_6 = Instantiate(COLLECTIBLE_PREFAB, POS_6.transform.position, POS_6.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_6 = false;

            }
            if (RANDOM_POSITION == 7 && SPACE_CHECKER_7 == true)
            {
                PREFAB_7 = Instantiate(COLLECTIBLE_PREFAB, POS_7.transform.position, POS_7.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_7 = false;

            }
            if (RANDOM_POSITION == 8 && SPACE_CHECKER_8 == true)
            {
                PREFAB_8 = Instantiate(COLLECTIBLE_PREFAB, POS_8.transform.position, POS_8.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_8 = false;

            }
            if (RANDOM_POSITION == 9 && SPACE_CHECKER_9 == true)
            {
                PREFAB_9 = Instantiate(COLLECTIBLE_PREFAB, POS_9.transform.position, POS_9.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_9 = false;

            }
            if (RANDOM_POSITION == 10 && SPACE_CHECKER_10 == true)
            {
                PREFAB_10 = Instantiate(COLLECTIBLE_PREFAB, POS_10.transform.position, POS_10.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_10 = false;

            }
        if (RANDOM_POSITION == 11 && SPACE_CHECKER_11 == true)
        {
            PREFAB_11 = Instantiate(COLLECTIBLE_PREFAB, POS_11.transform.position, POS_11.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_11 = false;

        }
        if (RANDOM_POSITION == 12 && SPACE_CHECKER_12 == true)
        {
            PREFAB_12 = Instantiate(COLLECTIBLE_PREFAB, POS_12.transform.position, POS_12.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_12 = false;

        }
        if (RANDOM_POSITION == 13 && SPACE_CHECKER_13 == true)
        {
            PREFAB_13 = Instantiate(COLLECTIBLE_PREFAB, POS_13.transform.position, POS_13.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_13 = false;

        }
        if (RANDOM_POSITION == 14 && SPACE_CHECKER_14 == true)
        {
            PREFAB_14 = Instantiate(COLLECTIBLE_PREFAB, POS_14.transform.position, POS_14.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_14 = false;

        }
        if (RANDOM_POSITION == 15 && SPACE_CHECKER_15 == true)
        {
            PREFAB_15 = Instantiate(COLLECTIBLE_PREFAB, POS_15.transform.position, POS_15.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_15 = false;

        }
        if (RANDOM_POSITION == 16 && SPACE_CHECKER_16 == true)
        {
            PREFAB_16 = Instantiate(COLLECTIBLE_PREFAB, POS_16.transform.position, POS_16.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_16 = false;

        }
        if (RANDOM_POSITION == 17 && SPACE_CHECKER_17 == true)
        {
            PREFAB_17 = Instantiate(COLLECTIBLE_PREFAB, POS_17.transform.position, POS_17.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_17 = false;

        }
        if (RANDOM_POSITION == 18 && SPACE_CHECKER_18 == true)
        {
            PREFAB_18 = Instantiate(COLLECTIBLE_PREFAB, POS_18.transform.position, POS_18.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_18 = false;

        }
        if (RANDOM_POSITION == 19 && SPACE_CHECKER_19 == true)
        {
            PREFAB_19 = Instantiate(COLLECTIBLE_PREFAB, POS_19.transform.position, POS_19.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_19 = false;

        }
        if (RANDOM_POSITION == 20 && SPACE_CHECKER_20 == true)
        {
            PREFAB_20 = Instantiate(COLLECTIBLE_PREFAB, POS_20.transform.position, POS_20.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_20 = false;

        }
        if (RANDOM_POSITION == 21 && SPACE_CHECKER_21 == true)
        {
            PREFAB_21= Instantiate(COLLECTIBLE_PREFAB, POS_21.transform.position, POS_21.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_21 = false;

        }
        if (RANDOM_POSITION == 22 && SPACE_CHECKER_22 == true)
        {
            PREFAB_22 = Instantiate(COLLECTIBLE_PREFAB, POS_22.transform.position, POS_22.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_22 = false;

        }
        if (RANDOM_POSITION == 23 && SPACE_CHECKER_23 == true)
        {
            PREFAB_23 = Instantiate(COLLECTIBLE_PREFAB, POS_23.transform.position, POS_23.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_23 = false;

        }
        if (RANDOM_POSITION == 24 && SPACE_CHECKER_24 == true)
        {
            PREFAB_24 = Instantiate(COLLECTIBLE_PREFAB, POS_24.transform.position, POS_24.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_24 = false;
        }
        if (RANDOM_POSITION == 25 && SPACE_CHECKER_25 == true)
        {
            PREFAB_25 = Instantiate(COLLECTIBLE_PREFAB, POS_25.transform.position, POS_25.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_25 = false;
        }
        if (RANDOM_POSITION == 26 && SPACE_CHECKER_26 == true)
        {
            PREFAB_26 = Instantiate(COLLECTIBLE_PREFAB, POS_26.transform.position, POS_26.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_26 = false;
        }
        if (RANDOM_POSITION == 27 && SPACE_CHECKER_27 == true)
        {
            PREFAB_27 = Instantiate(COLLECTIBLE_PREFAB, POS_27.transform.position, POS_27.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_27 = false;
        }
        if (RANDOM_POSITION == 28 && SPACE_CHECKER_28 == true)
        {
            PREFAB_28 = Instantiate(COLLECTIBLE_PREFAB, POS_28.transform.position, POS_28.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_28 = false;
        }
        if (RANDOM_POSITION == 29 && SPACE_CHECKER_29 == true)
        {
            PREFAB_29 = Instantiate(COLLECTIBLE_PREFAB, POS_29.transform.position, POS_29.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_29 = false;
        }
        if (RANDOM_POSITION == 30 && SPACE_CHECKER_30 == true)
        {
            PREFAB_30 = Instantiate(COLLECTIBLE_PREFAB, POS_30.transform.position, POS_30.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_30 = false;
        }
        if (RANDOM_POSITION == 31 && SPACE_CHECKER_31 == true)
        {
            PREFAB_31 = Instantiate(COLLECTIBLE_PREFAB, POS_31.transform.position, POS_31.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_31 = false;
        }
        if (RANDOM_POSITION == 32 && SPACE_CHECKER_32 == true)
        {
            PREFAB_32 = Instantiate(COLLECTIBLE_PREFAB, POS_32.transform.position, POS_32.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_32 = false;
        }
        if (RANDOM_POSITION == 33 && SPACE_CHECKER_33 == true)
        {
            PREFAB_33 = Instantiate(COLLECTIBLE_PREFAB, POS_33.transform.position, POS_33.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_33 = false;
        }
        if (RANDOM_POSITION == 34 && SPACE_CHECKER_34 == true)
        {
            PREFAB_34 = Instantiate(COLLECTIBLE_PREFAB, POS_34.transform.position, POS_34.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_34 = false;
        }
        if (RANDOM_POSITION == 35 && SPACE_CHECKER_35 == true)
        {
            PREFAB_35 = Instantiate(COLLECTIBLE_PREFAB, POS_35.transform.position, POS_35.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_35 = false;
        }
        if (RANDOM_POSITION == 36 && SPACE_CHECKER_36 == true)
        {
            PREFAB_36 = Instantiate(COLLECTIBLE_PREFAB, POS_36.transform.position, POS_36.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_36 = false;
        }
        if (RANDOM_POSITION == 37 && SPACE_CHECKER_37 == true)
        {
            PREFAB_37 = Instantiate(COLLECTIBLE_PREFAB, POS_37.transform.position, POS_37.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_37 = false;
        }
        if (RANDOM_POSITION == 38 && SPACE_CHECKER_38 == true)
        {
            PREFAB_38 = Instantiate(COLLECTIBLE_PREFAB, POS_38.transform.position, POS_38.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_38 = false;
        }
        if (RANDOM_POSITION == 39 && SPACE_CHECKER_39 == true)
        {
            PREFAB_39 = Instantiate(COLLECTIBLE_PREFAB, POS_39.transform.position, POS_39.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
            SPACE_CHECKER_39 = false;
        }
    }
}

    
