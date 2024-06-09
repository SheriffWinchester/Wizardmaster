using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsSummoning : MonoBehaviour
{
    public KeyCode[] unitCombo = new KeyCode[5];
    bool comboEntered = false;
    private bool bDetectKey;
    private KeyCode kCode;
    public string combo;
    public GameObject unit1;
    public GameObject unit2;
    public GameObject unit3;
    public UnitsBaseData unitsBaseData;
    int i = 0;
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
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            comboEntered = true;
        }

        // Call the SpawnUnit function
        // !!!!!!!!! Need to refactor somehow !!!!!!!!!!
        SpawnUnit(KeyCode.W, KeyCode.W, KeyCode.W, KeyCode.None, KeyCode.None, unit1);
        SpawnUnit(KeyCode.W, KeyCode.S, KeyCode.W, KeyCode.None, KeyCode.None, unit2);
        SpawnUnit(KeyCode.W, KeyCode.W, KeyCode.W, KeyCode.S, KeyCode.S, unit2);

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
    public void SpawnUnit(KeyCode key1, KeyCode key2, KeyCode key3, KeyCode key4, KeyCode key5, GameObject unit)
    {
        if (comboEntered == true && unitCombo[0] == key1 && unitCombo[1] == key2 && unitCombo[2] == key3 && unitCombo[3] == key4  && unitCombo[4] == key5)
        {
            Debug.Log("Unit1 spawned!");
            i = 0;
            comboEntered = false; 
            float yPos = Random.Range(-1.0f, 1.0f);
            Vector3 randomPosition = new Vector3(-4f, yPos, 0);
            GameObject newUnit = Instantiate(unit, randomPosition, Quaternion.identity);
            // Clear the unitCombo array
            for (int j = 0; j < unitCombo.Length; j++)
            {
                unitCombo[j] = KeyCode.None;
            }
        }
    }
}