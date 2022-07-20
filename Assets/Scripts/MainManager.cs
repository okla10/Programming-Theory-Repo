using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainManager : MonoBehaviour
{
    public TextMeshProUGUI playerText;
    // Start is called before the first frame update
    void Start()
    {
        playerText.text = "Player name is " + MenuManager.instance.playerName.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
