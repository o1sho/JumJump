using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] public Button continueButton;

    private void OnEnable()
    {
        Time.timeScale = 0f;
        if (CoinsController.coins >= 30)
        {
            continueButton.interactable = true;
        } else if (CoinsController.coins < 30) continueButton.interactable = false;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
        CoinsController.coins -= 30;
    }


}
