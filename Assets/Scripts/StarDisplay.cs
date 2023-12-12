using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int stars = 100;
    Text starText;
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay() 
    {
        starText.text = stars.ToString();
    }
    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public void SpendStars (int amount)
    {
        if (stars >= amount)
        {

            stars -= amount;
            UpdateDisplay();
        }
    }


    // Update is called once per frame
  
}
