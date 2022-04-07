using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playable : MonoBehaviour
{
    public Text p11;
    public Text p12;
    public Text p13;
    public Text p21;
    public Text p22;
    public Text p23;
    public Text p31;
    public Text p32;
    public Text p33;
    public Text win;

    public Button prompt;
    public Button b11;
    public Button b12;
    public Button b13;
    public Button b21;
    public Button b22;
    public Button b23;
    public Button b31;
    public Button b32;
    public Button b33;

    public GameObject button1;
    public GameObject player1;
    public GameObject player2;


    public void worng_checker(Button button)
    {
        button.interactable = false;

        if (player1.activeSelf)
        {
            button.GetComponentInChildren<Text>().text = "X";
            player2.SetActive(true);
            player1.SetActive(false);
        }
        else
        {
            button.GetComponentInChildren<Text>().text = "O";
            player2.SetActive(false);
            player1.SetActive(true);
        }

        win_checker();      
    }

    public void win_checker()
    {
        if (p11.text.ToString() == p12.text.ToString() && p11.text.ToString() == p13.text.ToString())
        {
            if (p11.text.ToString() == "X")
            {
                win.enabled = true;
                win.text = "Player 1 Won";
                button1.SetActive(true);
                prompt.interactable = true;  
            }
            else if (p11.text.ToString() == "O")
            {
                win.enabled = true;
                win.text = "Player 2 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
        }
        else if (p11.text.ToString() == p21.text.ToString() && p11.text.ToString() == p31.text.ToString())
        {
            if (p11.text.ToString() == "X")
            {
                win.enabled = true;
                win.text = "Player 1 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
            else if (p11.text.ToString() == "O")
            {
                win.enabled = true;
                win.text = "Player 2 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
        }
        else if (p21.text.ToString() == p22.text.ToString() && p21.text.ToString() == p23.text.ToString())
        {
            if (p21.text.ToString() == "X")
            {
                win.enabled = true;
                win.text = "Player 1 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
            else if (p21.text.ToString() == "O")
            {
                win.enabled = true;
                win.text = "Player 2 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
        }
        else if (p12.text.ToString() == p22.text.ToString() && p12.text.ToString() == p32.text.ToString())
        {
            if (p22.text.ToString() == "X")
            {
                win.enabled = true;
                win.text = "Player 1 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
            else if (p22.text.ToString() == "O")
            {
                win.enabled = true;
                win.text = "Player 2 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
        }
        else if (p31.text.ToString() == p32.text.ToString() && p31.text.ToString() == p33.text.ToString())
        {
            if (p31.text.ToString() == "X")
            {
                win.enabled = true;
                win.text = "Player 1 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
            else if (p31.text.ToString() == "O")
            {
                win.enabled = true;
                win.text = "Player 2 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
        }
        else if (p13.text.ToString() == p23.text.ToString() && p13.text.ToString() == p33.text.ToString())
        {
            if (p23.text.ToString() == "X")
            {
                win.enabled = true;
                win.text = "Player 1 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
            else if (p23.text.ToString() == "O")
            {
                win.enabled = true;
                win.text = "Player 2 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
        }
        else if (p11.text.ToString() == p22.text.ToString() && p11.text.ToString() == p33.text.ToString())
        {
            if (p11.text.ToString() == "X")
            {
                win.enabled = true;
                win.text = "Player 1 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
            else if (p11.text.ToString() == "O")
            {
                win.enabled = true;
                win.text = "Player 2 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
        }
        else if (p13.text.ToString() == p22.text.ToString() && p13.text.ToString() == p31.text.ToString())
        {
            if (p22.text.ToString() == "X")
            {
                win.enabled = true;
                win.text = "Player 1 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
            else if (p22.text.ToString() == "O")
            {
                win.enabled = true;
                win.text = "Player 2 Won";
                button1.SetActive(true);
                prompt.interactable = true;
            }
        }
        else
        {
            if (p11.text.ToString()!=" " && p12.text.ToString()!= " " && p13.text.ToString()!= " " && p21.text.ToString()!= " " && p22.text.ToString()!= " " && p23.text.ToString()!= " " && p31.text.ToString()!= " " && p32.text.ToString()!= " " && p33.text.ToString()!= " " )
            {
                button1.SetActive(true);
                prompt.interactable = true;
                win.enabled = true;
                win.text = "Draw";
            }
        }

    }

    public void clear_board()
    {
        win.text = " ";
        win.enabled = false;
        button1.SetActive(false);
        prompt.interactable = false;
        player1.SetActive(true);
        player2.SetActive(false);
        b11.interactable = true;
        b12.interactable = true;
        b13.interactable = true;
        b21.interactable = true;
        b22.interactable = true;
        b23.interactable = true;
        b31.interactable = true;
        b32.interactable = true;
        b33.interactable = true;
        p11.text = " ";
        p12.text = " ";
        p13.text = " ";
        p22.text = " ";
        p32.text = " ";
        p31.text = " ";
        p33.text = " ";
        p21.text = " ";
        p23.text = " ";
    }
}
