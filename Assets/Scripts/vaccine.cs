using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vaccine : MonoBehaviour {

    public Text vaccineText;
    static int Vaccine = 0;



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            Destroy(gameObject);
            Updatevaccine();
        }
    }
    public void Updatevaccine()
    {
        Vaccine++;
        vaccineText.text = "Vaccine" + Vaccine;
    }
}
