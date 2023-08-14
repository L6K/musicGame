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
        comboText.text = GManager.instance.combo.ToString();
    }
    

    // Update is called once per frame
    void Update()
    {
        comboText.text = GManager.instance.combo.ToString();
    }
}
