using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    
    public bool PurchaseUpgrade(int cost)
    {
        if (score >= cost)
        {
            score -= cost;
            return true;
        }
        return false;
    }
    //Make Upgrade
     //If Score is greater than or equal to stats; upgrade , player can buy it
      //else You cannot buy the upgrade
      
}
