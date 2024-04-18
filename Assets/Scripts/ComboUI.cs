using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class ComboUI : MonoBehaviour
{
    public TextMeshProUGUI inputText; // Assign this in the inspector
    public GameObject objectWithScript;
    public Summoning summoningScript;

    // Update is called once per frame
    void Start()
    {
        inputText = GetComponent<TextMeshProUGUI>();
        summoningScript = objectWithScript.GetComponent<Summoning>();

    }
    void Update()
    {
        string combo = string.Join(" ", summoningScript.unitCombo.Select(k => k == KeyCode.None ? "" : k.ToString()).ToArray());
        inputText.text = combo;
    }
}