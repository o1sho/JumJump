using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] public Button continueButton;
    [SerializeField] public int continuePriseCoins;

    private void OnEnable()
    {
        Time.timeScale = 0f;
        if (CoinsController.coins >= continuePriseCoins)
        {
            continueButton.interactable = true;
        } else if (CoinsController.coins < continuePriseCoins) continueButton.interactable = false;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
        CoinsController.coins -= continuePriseCoins;
    }


}
