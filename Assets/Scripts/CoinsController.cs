using TMPro;
using UnityEngine;

public class CoinsController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsText;
    public static int coins;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
    }

    private void Update()
    {
        _coinsText.text = "coins: " + coins.ToString();

        if (Input.GetKeyDown(KeyCode.C)) coins += 100;
    }

    public static void AddCoin()
    {
        coins++;
    }

    public void SaveEarnedCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }
}
