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
        //La vida no pasará de un máximo ni disminuirá de un mínimo
        vida = Mathf.Clamp(vida, 0, 100);
        barraDeVida.fillAmount = vida / 100; //Tomará la barra de vida y la llenará o deisminuirá

        if (vida == 0)
        {
            Debug.Log("Game Over!");
            Destroy(player);

        }
    }
}
