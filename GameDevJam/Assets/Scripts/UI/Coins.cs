using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coins : MonoBehaviour {
    private Text CoinsUIText;

    // Use this for initialization
    void Start()
    {
        CoinsUIText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CoinsUIText.text = "Coins : " + CollectCoins.Instance.coinCount ;
    }
}
