using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int coins;
    public UIManager uiManager;
    
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        uiManager.UpdateUI();
    }

    public void CollectCoin() {
        coins++;
        uiManager.UpdateUI();
    }
}
