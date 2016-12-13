using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuyMenu : MonoBehaviour {

    public GameObject menu;

    public GameObject playerObject;
    private Player _playerScript;

    public GameObject coinSpawnerObject;
    private CoinSpawner _coinSpawnerScript;


    public GameObject[] Texts;
    public GameObject[] Images;
    private Text[] _texts = new Text[3];


    // Use this for initialization
    private void Start () {
        menu.SetActive(false);
        _playerScript = playerObject.GetComponent<Player>();
        _coinSpawnerScript = coinSpawnerObject.GetComponent<CoinSpawner>();
        for (int i = 0; i < Texts.Length; i++)
        {
            _texts[i] = Texts[i].GetComponent<Text>();
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (GlobalPause.Instance.isPaused)
        {
            menu.SetActive(true);
        }
        else
        {
            menu.SetActive(false);
        }
    }

    public void DoubleSpeed()
    {
        if (CollectCoins.Instance.coinCount >= 3)
        {
            CollectCoins.Instance.coinCount -= 3;
            ChangeSpeed();
            _texts[0].text = "PURCHASED!";
            Destroy(Images[0]);
        }
    }

    public void DoubleCoins()
    {
        if (CollectCoins.Instance.coinCount >= 5)
        {
            CollectCoins.Instance.coinCount -= 5;
            ChangeCoinSpawn();
            _texts[1].text = "PURCHASED!";
            Destroy(Images[1]);
        }
    }

    public void ExtraJump()
    {
        if (CollectCoins.Instance.coinCount >= 10)
        {
            CollectCoins.Instance.coinCount -= 10;
            AddJump();
            _texts[2].text = "PURCHASED!";
            Destroy(Images[2]);
        }
    }

    void ChangeSpeed()
    {
        MoveBuildings.movement = new Vector3(-.15f, 0f, 0f);
    }

    void ChangeCoinSpawn()
    {
        _coinSpawnerScript.timeBetweenSpawn = 2f;
    }

    void AddJump()
    {
        _playerScript.maxJumps = 3;
    }
}
