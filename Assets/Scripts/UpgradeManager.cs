using TMPro;
using UnityEngine;



public class UpgradeManager : MonoBehaviour
{
    public TMP_Text priceText;
    
    
    public int priceStart = 10, rank = 0;
    public float upgradeMultiplier = 1.25f, scorePerSecond = 0;
    public ScoreManager scoreManager;
    
    
    private void Start()
    {
        UpdateUI();
    }
    
    
    void UpdateUI()
    {
        priceText.text = CalculateUpgradePrice().ToString();
    }
    
    //figure out a formula to how much you charge the player, play with the numbers, maybe brainstorm
    int CalculateUpgradePrice() => Mathf.RoundToInt(priceStart * upgradeMultiplier);

    public bool BuyUpdate()
    {
        // if the player score is less than the upgrade price, do nothing (return false)
        if (scoreManager.score < CalculateUpgradePrice())
        {
            // do stuff to tell players they are broke
            return false;
        }
        
        //score = score - upgrade price
        scoreManager.score -= CalculateUpgradePrice();
        // rank = rank + 1
        rank += 1;
        if (scorePerSecond == 0)
        {
            scorePerSecond = 0.1f;
        }
        else
        {
            scorePerSecond *= upgradeMultiplier;
        }
        // finish up
        return true;
    }
    
    //i need an event to occur where i reduce the multiplier
    
    // if the player does this action, or meets this requirement
        // remove one rank
    // else
        // do something else
}
