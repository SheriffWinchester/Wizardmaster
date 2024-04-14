using UnityEngine;
using UnityEngine.UI;

public class ComboUI : MonoBehaviour
{
    public Text inputText; // Assign this in the inspector

    private KeyCode[] unit1combo = new KeyCode[] { KeyCode.UpArrow, KeyCode.UpArrow, KeyCode.UpArrow, KeyCode.UpArrow };
    private KeyCode[] unit2combo = new KeyCode[] { KeyCode.UpArrow, KeyCode.UpArrow, KeyCode.LeftArrow, KeyCode.RightArrow };

    // Update is called once per frame
    void Start()
    {
        inputText = GetComponent<Text>();
    }
    void Update()
    {
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < unit1combo.Length; i++)
            {
                if (Input.GetKeyDown(unit1combo[i]))
                {
                    inputText.text += " " + unit1combo[i].ToString();
                    break;
                }
            }

            for (int i = 0; i < unit2combo.Length; i++)
            {
                if (Input.GetKeyDown(unit2combo[i]))
                {
                    inputText.text += " " + unit2combo[i].ToString();
                    break;
                }
            }
        }
    }
}