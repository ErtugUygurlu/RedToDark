using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top_kontrol : MonoBehaviour
{
    public Rigidbody top_rigi;
    Vector3 baslangic_koordinatlari;
    float hiz = 7.0f;
    [SerializeField] private Game_Manager game_manager;

    public GameObject oyunbitti;



    void Start()
    {
        Time.timeScale = 1f;
        baslangic_koordinatlari = transform.position;
        baslangic_vurusu();
    }

    void baslangic_vurusu()
    {
        top_rigi.velocity = Vector3.zero;
        transform.position = baslangic_koordinatlari;
        top_rigi.velocity = new Vector3(hiz, 0, hiz);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "sag_duvar")
        {
            top_rigi.velocity = new Vector3(-hiz, 0, top_rigi.velocity.z);
        }

        if (other.gameObject.name == "sol_duvar")
        {
            top_rigi.velocity = new Vector3(hiz, 0, top_rigi.velocity.z);
        }




    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "yildiz")
        {
            game_manager.star_count++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "finish")
        {
            oyunbitti.SetActive(true);
            Time.timeScale = 0f;




        }
        if (other.gameObject.tag == "geberdin")
        {
            game_manager.GameOver();
        }

    }

}
