using UnityEngine;

public class Summoning : MonoBehaviour
{
    private int positionInSequence1 = 0;
    private int positionInSequence2 = 0;
    private KeyCode[] unit1combo = new KeyCode[] { KeyCode.W, KeyCode.W, KeyCode.W, KeyCode.W };
    private KeyCode[] unit2combo = new KeyCode[] { KeyCode.W, KeyCode.W, KeyCode.A, KeyCode.D };
    bool isCombo = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(unit1combo[positionInSequence1]))
            {
                positionInSequence1++;
                if (positionInSequence1 >= unit1combo.Length)
                {
                    positionInSequence1 = 0;
                    positionInSequence2 = 0;
                    SpawnUnit1();
                }
            }
            else
            {
                positionInSequence1 = 0;
            }
            
            if (Input.GetKeyDown(unit2combo[positionInSequence2]))
            {
                positionInSequence2++;
                if (positionInSequence2 >= unit2combo.Length)
                {
                    positionInSequence1 = 0;
                    positionInSequence2 = 0;
                    SpawnUnit2();
                }
            }
            else
            {
                positionInSequence2 = 0;
            }
            Debug.Log("P1: " + positionInSequence1);
            Debug.Log("P2: " + positionInSequence2);
        }
    }

    // Define the SpawnUnit1 function
    void SpawnUnit1()
    {
        // Add the code for what you want to happen when the user presses the sequence
        Debug.Log("Unit1 spawned!");
        return;
    }

    // Define the SpawnUnit2 function
    void SpawnUnit2()
    {
        // Add the code for what you want to happen when the user presses the sequence
        Debug.Log("Unit2 spawned!");
        return;
    }
    
    void DefaultPositionInSequence()
    {
        positionInSequence1 = 0;
        positionInSequence2 = 0;
    }
}