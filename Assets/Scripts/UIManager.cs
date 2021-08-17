using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text coinsText;
    public GameManager manager;

    // Update is called once per frame
    public void UpdateUI()
    {
        coinsText.text = manager.coins.ToString();
    }
}
