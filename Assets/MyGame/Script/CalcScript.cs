using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CalcScript : MonoBehaviour
{
    public Text NameOut;
    public Text CountOut;
    public Button Namebtn;
    public Button Countbtn;
    public InputField Namein;
    public int CountNumber = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetName()
    {
        NameOut.text = Namein.text;
    }

    public void CountUp()
    {
        CountNumber++;
        CountOut.text = CountNumber.ToString();
    }
}
