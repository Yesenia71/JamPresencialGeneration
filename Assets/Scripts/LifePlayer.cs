using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour
{
    LifePlayer player;

    public float vida = 100;
    public Image barraDeVida;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<LifePlayer>();
    }

    void Update()
    {
        //La vida no pasar� de un m�ximo ni disminuir� de un m�nimo
        vida = Mathf.Clamp(vida, 0, 100);
        barraDeVida.fillAmount = vida / 100; //Tomar� la barra de vida y la llenar� o deisminuir�

        if (vida == 0)
        {
            Debug.Log("Game Over!");
            Destroy(player);

        }
    }
}
