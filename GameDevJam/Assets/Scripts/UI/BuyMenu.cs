using UnityEngine;
using System.Collections;

public class BuyMenu : MonoBehaviour {

    public GameObject menu;

    public GameObject playerObject;
    private Player _playerScript;

    public GameObject coinSpawnerObject;
    private CoinSpawner _coinSpawnerScript;


	// Use this for initialization
	void Start () {
        menu.SetActive(false);
        _playerScript = playerObject.GetComponent<Player>();
        _coinSpawnerScript = coinSpawnerObject.GetComponent<CoinSpawner>();
    

    }

    // Update is called once per frame
    void Update()
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
        }
    }

    public void DoubleCoins()
    {
        if (CollectCoins.Instance.coinCount >= 5)
        {
            CollectCoins.Instance.coinCount -= 5;
            ChangeCoinSpawn();
        }
    }

    public void ExtraJump()
    {
        if (CollectCoins.Instance.coinCount >= 10)
        {
            CollectCoins.Instance.coinCount -= 10;
            AddJump();
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
