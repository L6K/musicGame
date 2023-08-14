using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Combo : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI comboText;

    // Start is called before the first frame update
    void Start()
    {
        comboText.alpha = 30;
        comboText.text = $"<color=red><alpha=#88>{GManager.instance.combo}</color>";
    }
    

    // Update is called once per frame
    void Update()
    {
        comboText.text = $"<color=red><alpha=#88>{GManager.instance.combo}</color>";
        Debug.Log("Combo Increased: " + GManager.instance.combo);
    }
}
