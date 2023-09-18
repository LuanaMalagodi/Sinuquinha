using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hole : MonoBehaviour
{
    public Text lostText;
    public Text ballText;
    public Text winText;
    public Button replayB;
    private int ballcount = 0;
    public GameObject player;

    void Start()
    {
        lostText.gameObject.SetActive(false);
        winText.gameObject.SetActive(false);
        replayB.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            other.gameObject.SetActive(false);
            ballcount++;
            ballText.text = ballcount.ToString();

        } 

        if (ballcount >= 9)
        {
            //winText.text = "You Win!!";
            winText.gameObject.SetActive(true);
            replayB.gameObject.SetActive(true);
            player.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
            //lostText.text = "GAME OVER";
            winText.gameObject.SetActive(false);
            lostText.gameObject.SetActive(true);
            replayB.gameObject.SetActive(true);
        }

    }
}
