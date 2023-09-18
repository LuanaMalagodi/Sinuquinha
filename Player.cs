using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveBall : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidade = 5;
    private int count;
    public Text countText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }
    void Update()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");
        Vector3 movimento = new Vector3(movimentoVertical * -1, 0.0f, movimentoHorizontal);
        rb.AddForce(movimento * velocidade);
        countText.text = count.ToString();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pickup")
        {
            other.gameObject.SetActive(false);
        }
        count = count + 1;
        //Debug.Log(count);
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene("Main");
    }

}
