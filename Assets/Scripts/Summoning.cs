using UnityEngine;
using System;

public class Summoning : MonoBehaviour
{
    public KeyCode[] unitCombo = new KeyCode[5];
    int i = 0;
    bool comboEntered = false;
    private bool bDetectKey;
    private KeyCode kCode;
    public string combo;
    public GameObject unit1;
    public GameObject unit2;

    // Update is called once per frame
    public void Update()
    {
        if (Input.anyKeyDown)
        {
            DetectInput(); //detects the key being pressed
            if (i < 5)
            {
                if (kCode == KeyCode.W || kCode == KeyCode.A || kCode == KeyCode.D || kCode == KeyCode.S)
                {
                    unitCombo[i] = kCode;
                    combo = unitCombo[0].ToString() + unitCombo[1].ToString() + unitCombo[2].ToString() + unitCombo[3].ToString() + unitCombo[4].ToString(); //Converts the KeyCode to a string
                    Debug.Log($"Key pressed: {i}, {combo}, {comboEntered}");
                    ++i;
                }
            }
            // else
            // {
            //     Debug.Log("Combo: " + combo);
            //     i = 0;
            //     for (int j = 0; j < unitCombo.Length; j++)
            //     {
            //         unitCombo[j] = KeyCode.None;
            //     }
            // }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            comboEntered = true;
        }
        if (comboEntered == true && unitCombo[0] == KeyCode.W && unitCombo[1] == KeyCode.W && unitCombo[2] == KeyCode.W && unitCombo[3] == KeyCode.None  && unitCombo[4] == KeyCode.None)
        {
            Debug.Log("Unit1 spawned!");
            i = 0;
            comboEntered = false;
            Instantiate(unit1, new Vector3(-4, 2, 0), Quaternion.identity);
            // Clear the unitCombo array
            for (int j = 0; j < unitCombo.Length; j++)
            {
                unitCombo[j] = KeyCode.None;
            }
        }
        if (comboEntered == true && (unitCombo[0] == KeyCode.W && unitCombo[1] == KeyCode.S && unitCombo[2] == KeyCode.W && unitCombo[3] == KeyCode.None  && unitCombo[4] == KeyCode.None))
        {
            Debug.Log("Unit1 spawned!");
            i = 0;
            comboEntered = false;
            // Clear the unitCombo array
            for (int j = 0; j < unitCombo.Length; j++)
            {
                unitCombo[j] = KeyCode.None;
            }
        }
        if (comboEntered == true && unitCombo[0] == KeyCode.W && unitCombo[1] == KeyCode.W && unitCombo[2] == KeyCode.W && unitCombo[3] == KeyCode.S && unitCombo[4] == KeyCode.S)
        {
            Debug.Log("Unit1 spawned!");
            i = 0;
            comboEntered = false;
            Instantiate(unit2, new Vector3(-4, 0, 0), Quaternion.identity);
            // Clear the unitCombo array
            for (int j = 0; j < unitCombo.Length; j++)
            {
                unitCombo[j] = KeyCode.None;
            }
        }
        if (comboEntered == true)
        {
            comboEntered = false;
            i = 0;
            for (int j = 0; j < unitCombo.Length; j++)
            {
                unitCombo[j] = KeyCode.None;
            }
        }
    }
    public void DetectInput()
    {
        foreach(KeyCode vkey in System.Enum.GetValues(typeof(KeyCode)))
        {
            if(Input.GetKeyDown(vkey))
            {
                if (vkey != KeyCode.Return)
                {
                    kCode = vkey; //this saves the key being pressed               
                    bDetectKey = false;
                }
            }
        }
    }

    // Define the SpawnUnit1 function
    // void SpawnUnit1()
    // {
    //     // Add the code for what you want to happen when the user presses the sequence
    //     Debug.Log("Unit1 spawned!");
    // }

    // // Define the SpawnUnit2 function
    // void SpawnUnit2()
    // {
    //     // Add the code for what you want to happen when the user presses the sequence
    //     Debug.Log("Unit2 spawned!");
    // }
    
    // void DefaultPositionInSequence()
    // {
    //     positionInSequence1 = 0;
    //     positionInSequence2 = 0;
    // }
}