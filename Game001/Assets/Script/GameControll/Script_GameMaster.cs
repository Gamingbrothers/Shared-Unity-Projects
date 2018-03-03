using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_GameMaster : MonoBehaviour {

    //Variables 
    #region
    public int playerOneHealth = 100;
    public int playerOneMoney = 0;
    public int playerOneMoneyGet = 1;

    public int playerTwoHealth = 100;
    public int playerTwoMoney = 0;
    public int playerTwoMoneyGet = 1; 

    //for UI
    public Text playerOneMoneyText;
    public Slider playerOneHPSlider; 

    


    #endregion



    // Use this for initialization
    void Start () {
        InvokeRepeating("GenerteMoneyPlayerOne", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {

        playerOneHPSlider.value = playerOneHealth;
        playerOneMoneyText.text = playerOneMoney.ToString(); 

	}

    public void GenerteMoneyPlayerOne()
    {
        playerOneMoney = playerOneMoney + playerOneMoneyGet;
    }

}
