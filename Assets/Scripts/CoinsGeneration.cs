using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsGeneration : MonoBehaviour
{
    public int coins;
    public GameObject coinPrefab;

    private float xMin = 26f;
    private float xMax = 34f;
    private float y = -1f;
    private float zMin = -58f;
    private float zMax = 39f;

    // Start is called before the first frame update
    void Start()
    {
        
        CoinGenerate(coins);
    }

    void CoinGenerate(int quantity) {
        for (int i = 0; i < quantity; i++) {
            float x = Random.Range(xMin, xMax);
            float z = Random.Range(zMin, zMax);

            GameObject coin = Instantiate(coinPrefab, new Vector3(x, y, z), Quaternion.identity);
            coin.transform.parent = this.gameObject.transform;
            coin.name = "Coin";
        }
    }
}
