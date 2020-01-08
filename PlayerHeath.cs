using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHeath : MonoBehaviour
{
    public Text text;
    public GameObject player;
    public static int currenthealth = 100;
    public ParticleSystem explosion;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currenthealth <= 0)
        {
            currenthealth = 0;
            Vector3 position = player.transform.position;
            Destroy(player);
            ParticleSystem boominstance = Instantiate(explosion, position, Quaternion.identity);
            //SceneManager.UnloadSceneAsync("Turret Warfare");
            SceneManager.LoadScene("Home Scene", LoadSceneMode.Single);
            currenthealth = 100;
            Score.currentscore = 0;
        }
        else
        {
            text.text = "Health: " + currenthealth;
        }
    }
}
