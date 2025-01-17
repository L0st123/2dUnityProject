using UnityEngine;
using UnityEngine.UI;

public class CoinsSystem : MonoBehaviour
{
    public float CoinsAmount = 0;
    public Text text; 

    void Start()
    {
        
    }

    void Update()
    {
        text.text = CoinsAmount.ToString();
    }

}
