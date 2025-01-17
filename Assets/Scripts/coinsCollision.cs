using System.Xml;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class coinsCollision : MonoBehaviour
{
    public CoinsSystem coinsSystem; 
    public Text coinsText;         

    void Start()
    {
       
        if (coinsSystem == null)
          {
            Debug.LogError("CoinsSystem not found in the scene!");
           }
        

        if (coinsText == null)
        {
            Debug.LogError("CoinsText is not assigned in the Inspector!");
        }
    }
     void Update()
    {
        WinScreen();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (coinsSystem != null)
        {
            coinsSystem.CoinsAmount += 1;
            UpdateCoinsUI();
            this.gameObject.SetActive(false);
        }
    }

    private void UpdateCoinsUI()
    {
        if (coinsText != null)
        {
            coinsText.text = "Coins: " + coinsSystem.CoinsAmount;
        }
        else
        {
            Debug.LogError("coinsText is not initialized.");
        }
    }

    private void WinScreen()
    {
        if (coinsSystem.CoinsAmount >= 8)
        {
            SceneManager.LoadScene("winScreen");
        }
    }
}
