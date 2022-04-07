using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class  Check_win: MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;

    public Button mode;

    public GameObject top;
    public GameObject bottom;
    public GameObject left;
    public GameObject right;

    public GameObject main;
    public GameObject d_light;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    player_selector(hit.transform.gameObject);
                }
            }
        }
    }

    public void player_selector(GameObject gameobject1)
    {
        string Object = gameobject1.name;

        if (Object=="Prompt")
        {
            fresh_start();
        }
        else if (Object.Length<4)
        {
            string tile = "/" + gameobject1.name + "T";

            GameObject activate = GameObject.Find(tile);

            if (p1.activeSelf)
            {
                if (activate.GetComponent<TextMesh>().text == " ")
                {
                    activate.GetComponent<TextMesh>().text = "X";
                    p2.SetActive(true);
                    p1.SetActive(false);
                }
            }
            else
            {
                if (activate.GetComponent<TextMesh>().text == " ")
                {
                    activate.GetComponent<TextMesh>().text = "O";
                    p1.SetActive(true);
                    p2.SetActive(false);
                }
            }

            check_win();
        }
    }

    public void check_win()
    {
        TextMesh p11 = GameObject.Find("11T").GetComponent<TextMesh>();
        TextMesh p12 = GameObject.Find("12T").GetComponent<TextMesh>();
        TextMesh p13 = GameObject.Find("13T").GetComponent<TextMesh>();
        TextMesh p21 = GameObject.Find("21T").GetComponent<TextMesh>();
        TextMesh p22 = GameObject.Find("22T").GetComponent<TextMesh>();
        TextMesh p23 = GameObject.Find("23T").GetComponent<TextMesh>();
        TextMesh p31 = GameObject.Find("31T").GetComponent<TextMesh>();
        TextMesh p32 = GameObject.Find("32T").GetComponent<TextMesh>();
        TextMesh p33 = GameObject.Find("33T").GetComponent<TextMesh>();
        TextMesh prompt_text = GameObject.Find("Prompt T").GetComponent<TextMesh>();

        GameObject prompt = GameObject.Find("Prompt");

        string g11,g12,g13,g21,g22,g23,g31,g32,g33;

        g11 = p11.text.ToString();
        g12 = p12.text.ToString();
        g13 = p13.text.ToString();
        g21 = p21.text.ToString();
        g22 = p22.text.ToString();
        g23 = p23.text.ToString();
        g31 = p31.text.ToString();
        g32 = p32.text.ToString();
        g33 = p33.text.ToString();

        if (g11==g12 && g12==g13 && g11!=" ")
        {
            if (g11 == "X")
            {
                prompt_text.text = "Player 1 Won";
            }
            else if(g11 == "O")
            {
                prompt_text.text = "Player 2 Won";
            }
            prompt.transform.position = new Vector3(0.0104f, 2.5f, 0.0025f);
            clear();
        }
        else if (g21==g22 && g22==g23 && g22 != " ")
        {
            if (g21 == "X")
            {
                prompt_text.text = "Player 1 Won";
            }
            else if (g21 == "O")
            {
                prompt_text.text = "Player 2 Won";
            }
            prompt.transform.position = new Vector3(0.0104f, 2.5f, 0.0025f);
            clear();
        }
        else if (g31==g32 && g32==g33 && g33 != " ")
        {
            if (g31 == "X")
            {
                prompt_text.text = "Player 1 Won";
            }
            else if (g31 == "O")
            {
                prompt_text.text = "Player 2 Won";
            }
            prompt.transform.position = new Vector3(0.0104f, 2.5f, 0.0025f);
            clear();
        }
        else if (g11==g21 && g21==g31 && g11 != " ")
        {
            if (g11 == "X")
            {
                prompt_text.text = "Player 1 Won";
            }
            else if (g11 == "O")
            {
                prompt_text.text = "Player 2 Won";
            }
            prompt.transform.position = new Vector3(0.0104f, 2.5f, 0.0025f);
            clear();
        }
        else if (g12==g22 && g22==g32 && g22 != " ")
        {
            if (g12 == "X")
            {
                prompt_text.text = "Player 1 Won";
            }
            else if (g12 == "O")
            {
                prompt_text.text = "Player 2 Won";
            }
            prompt.transform.position = new Vector3(0.0104f, 2.5f, 0.0025f);
            clear();
        }
        else if (g13==g23 && g23==g33 && g33 != " ")
        {
            if (g13 == "X")
            {
                prompt_text.text = "Player 1 Won";
            }
            else if (g13 == "O")
            {
                prompt_text.text = "Player 2 Won";
            }
            prompt.transform.position = new Vector3(0.0104f, 2.5f, 0.0025f);
            clear();
        }
        else if (g11==g22 && g22==g33 && g11 != " ")
        {
            if (g11 == "X")
            {
                prompt_text.text = "Player 1 Won";
            }
            else if (g11 == "O")
            {
                prompt_text.text = "Player 2 Won";
            }
            prompt.transform.position = new Vector3(0.0104f, 2.5f, 0.0025f);
            clear();
        }
        else if (g13==g22 && g22==g31 && g22 != " ")
        {
            if (g13 == "X")
            {
                prompt_text.text = "Player 1 Won";
            }
            else if (g13 == "O")
            {
                prompt_text.text = "Player 2 Won";
            }
            prompt.transform.position = new Vector3(0.0104f, 2.5f, 0.0025f);
            clear();
        }
        else if(g11 !=" " && g12 != " " && g13 != " " && g21 != " " && g22 != " " && g23 != " " && g31 != " " && g32 != " " && g33 != " " )
        {
            prompt.transform.position = new Vector3(0.0104f, 2.5f, 0.0025f);
            prompt_text.text = "Draw";
            clear();
        }
    }

    public void clear()
    {

        TextMesh t11 = GameObject.Find("11T").GetComponent<TextMesh>();
        TextMesh t12 = GameObject.Find("12T").GetComponent<TextMesh>();
        TextMesh t13 = GameObject.Find("13T").GetComponent<TextMesh>();
        TextMesh t21 = GameObject.Find("21T").GetComponent<TextMesh>();
        TextMesh t22 = GameObject.Find("22T").GetComponent<TextMesh>();
        TextMesh t23 = GameObject.Find("23T").GetComponent<TextMesh>();
        TextMesh t31 = GameObject.Find("31T").GetComponent<TextMesh>();
        TextMesh t32 = GameObject.Find("32T").GetComponent<TextMesh>();
        TextMesh t33 = GameObject.Find("33T").GetComponent<TextMesh>();

        t11.text = " ";
        t12.text = " ";
        t13.text = " ";
        t21.text = " ";
        t22.text = " ";
        t23.text = " ";
        t31.text = " ";
        t32.text = " ";
        t33.text = " ";
    }

    public void fresh_start()
    {
        TextMesh prompt_text = GameObject.Find("Prompt T").GetComponent<TextMesh>();
        GameObject prompt = GameObject.Find("Prompt");

        prompt.transform.position = new Vector3(0.0104f, 1f, 0.0025f);
        prompt_text.text = " ";

        clear();

        p2.SetActive(false);
        p1.SetActive(true);
    }

    public void on_3d_click()
    {
        if (mode.GetComponentInChildren<Text>().text == "3D")
        {
            mode.GetComponentInChildren<Text>().text = "2D";

            top.SetActive(true);
            bottom.SetActive(true);
            left.SetActive(true);
            right.SetActive(true);

            on_bottom_click();
        }
        else
        {
            mode.GetComponentInChildren<Text>().text = "3D";

            top.SetActive(false);
            bottom.SetActive(false);
            left.SetActive(false);
            right.SetActive(false);

            on_mode();
        }
    }

    public void on_mode()
    {
        main.transform.position = new Vector3(0, 14, 0);
        main.transform.eulerAngles = new Vector3(90, 0, 0);

        GameObject p1_t = GameObject.Find("Player 1");
        GameObject p2_t = GameObject.Find("Player 2");

        p1.transform.eulerAngles = new Vector3(0, 0, 0);
        p1.transform.position = new Vector3(-10.1129f, 1.7699f, 0f);

        p2.transform.eulerAngles = new Vector3(0, 0, 0);
        p2.transform.position = new Vector3(9.988491f, 1.7699f, 0f);

        p1_t.transform.eulerAngles = new Vector3(90, 0, 0);
        p1_t.transform.position = new Vector3(-13.4f, 1f, 0.726172f);

        p2_t.transform.eulerAngles = new Vector3(90, 0, 0);
        p2_t.transform.position = new Vector3(8.4f, 1f, 0.726172f);

        d_light.transform.eulerAngles = new Vector3(50,-30, 0);
        d_light.transform.position = new Vector3(-6, 13, 8);

        GameObject t11 = GameObject.Find("11T");
        GameObject t12 = GameObject.Find("12T");
        GameObject t13 = GameObject.Find("13T");
        GameObject t21 = GameObject.Find("21T");
        GameObject t22 = GameObject.Find("22T");
        GameObject t23 = GameObject.Find("23T");
        GameObject t31 = GameObject.Find("31T");
        GameObject t32 = GameObject.Find("32T");
        GameObject t33 = GameObject.Find("33T");

        t11.transform.eulerAngles = new Vector3(90,0,0);
        t11.transform.position = new Vector3(-2.7141f,5f, 2.7141f);

        t12.transform.eulerAngles = new Vector3(90, 0, 0);
        t12.transform.position = new Vector3(-0.012556f, 5f, 2.7141f);

        t13.transform.eulerAngles = new Vector3(90, 0, 0);
        t13.transform.position = new Vector3(2.7141f, 5f, 2.7141f);

        t21.transform.eulerAngles = new Vector3(90, 0, 0);
        t21.transform.position = new Vector3(-2.7141f, 5f, 0f);

        t22.transform.eulerAngles = new Vector3(90, 0, 0);
        t22.transform.position = new Vector3(-0.012556f, 5f, 0f);

        t23.transform.eulerAngles = new Vector3(90, 0, 0);
        t23.transform.position = new Vector3(2.7141f, 5f, 0f);

        t31.transform.eulerAngles = new Vector3(90, 0, 0);
        t31.transform.position = new Vector3(-2.7141f, 5f, -2.7141f);

        t32.transform.eulerAngles = new Vector3(90, 0, 0);
        t32.transform.position = new Vector3(-0.012556f, 5f, -2.7141f);

        t33.transform.eulerAngles = new Vector3(90, 0, 0);
        t33.transform.position = new Vector3(2.7141f, 5f, -2.7141f);

        GameObject prompt_text = GameObject.Find("Prompt T");

        prompt_text.transform.eulerAngles = new Vector3(90,0,0);
        prompt_text.transform.position = new Vector3(-0.05f,2f,0f);
    }

    public void on_bottom_click()
    {
        main.transform.position = new Vector3(0,11,-9);
        main.transform.eulerAngles = new Vector3(51, 0, 0);

        GameObject p1_t = GameObject.Find("Player 1");
        GameObject p2_t = GameObject.Find("Player 2");

        p1.transform.eulerAngles = new Vector3(115, 0, 0);
        p1.transform.position = new Vector3(-10.1129f, 3f,0f);

        p2.transform.eulerAngles = new Vector3(115, 0, 0);
        p2.transform.position = new Vector3(9.988491f, 3f, 0f);

        p1_t.transform.eulerAngles = new Vector3(15, 0, 0);
        p1_t.transform.position = new Vector3(-13.5f, 3f, 0.726172f);

        p2_t.transform.eulerAngles = new Vector3(15, 0, 0);
        p2_t.transform.position = new Vector3(8.7f, 3f, 0.726172f);

        d_light.transform.eulerAngles = new Vector3(50, -30, 0);
        d_light.transform.position = new Vector3(-6, 13, 8);

        GameObject t11 = GameObject.Find("11T");
        GameObject t12 = GameObject.Find("12T");
        GameObject t13 = GameObject.Find("13T");
        GameObject t21 = GameObject.Find("21T");
        GameObject t22 = GameObject.Find("22T");
        GameObject t23 = GameObject.Find("23T");
        GameObject t31 = GameObject.Find("31T");
        GameObject t32 = GameObject.Find("32T");
        GameObject t33 = GameObject.Find("33T");

        t11.transform.eulerAngles = new Vector3(0, 0, 0);
        t11.transform.position = new Vector3(-2.7141f, 5f, 1.7141f);

        t12.transform.eulerAngles = new Vector3(0, 0, 0);
        t12.transform.position = new Vector3(-0.012556f, 5f, 1.7141f);

        t13.transform.eulerAngles = new Vector3(0, 0, 0);
        t13.transform.position = new Vector3(2.7141f, 5f, 1.7141f);

        t21.transform.eulerAngles = new Vector3(0, 0, 0);
        t21.transform.position = new Vector3(-2.7141f, 5f, -1f);

        t22.transform.eulerAngles = new Vector3(0, 0, 0);
        t22.transform.position = new Vector3(-0.012556f, 5f, -1f);

        t23.transform.eulerAngles = new Vector3(0, 0, 0);
        t23.transform.position = new Vector3(2.7141f, 5f, -1f);

        t31.transform.eulerAngles = new Vector3(0, 0, 0);
        t31.transform.position = new Vector3(-2.7141f, 5f, -3.7141f);

        t32.transform.eulerAngles = new Vector3(0, 0, 0);
        t32.transform.position = new Vector3(-0.012556f, 5f, -3.7141f);

        t33.transform.eulerAngles = new Vector3(0, 0, 0);
        t33.transform.position = new Vector3(2.7141f, 5f, -3.7141f);

        GameObject prompt_text = GameObject.Find("Prompt T");

        prompt_text.transform.eulerAngles = new Vector3(0, 0, 0);
        prompt_text.transform.position = new Vector3(-0.05f, 3f, 2f);
    }

    public void on_top_click()
    {
        main.transform.position = new Vector3(0, 11, 9);
        main.transform.eulerAngles = new Vector3(-231, 0, 180);

        GameObject p1_t = GameObject.Find("Player 1");
        GameObject p2_t = GameObject.Find("Player 2");

        p1.transform.eulerAngles = new Vector3(250, 0, 0);
        p1.transform.position = new Vector3(-10.1129f, 3f, 0f);

        p2.transform.eulerAngles = new Vector3(90, 0, 0);
        p2.transform.position = new Vector3(9.988491f, 3f, 0f);

        p1_t.transform.eulerAngles = new Vector3(160, 0, 180);
        p1_t.transform.position = new Vector3(-7.2f, 4.3f, 0.726172f);

        p2_t.transform.eulerAngles = new Vector3(160, 0, 180);
        p2_t.transform.position = new Vector3(11.8f, 4.3f, 0.726172f);

        d_light.transform.eulerAngles = new Vector3(50, 140, 140);
        d_light.transform.position = new Vector3(-6, 13, 8);

        GameObject t11 = GameObject.Find("11T");
        GameObject t12 = GameObject.Find("12T");
        GameObject t13 = GameObject.Find("13T");
        GameObject t21 = GameObject.Find("21T");
        GameObject t22 = GameObject.Find("22T");
        GameObject t23 = GameObject.Find("23T");
        GameObject t31 = GameObject.Find("31T");
        GameObject t32 = GameObject.Find("32T");
        GameObject t33 = GameObject.Find("33T");

        t11.transform.eulerAngles = new Vector3(0, 0, 0);
        t11.transform.position = new Vector3(-2.7141f, 5f, 3.7141f);

        t12.transform.eulerAngles = new Vector3(0, 0, 0);
        t12.transform.position = new Vector3(-0.012556f, 5f, 3.7141f);

        t13.transform.eulerAngles = new Vector3(0, 0, 0);
        t13.transform.position = new Vector3(2.7141f, 5f, 3.7141f);

        t21.transform.eulerAngles = new Vector3(0, 0, 0);
        t21.transform.position = new Vector3(-2.7141f, 5f, 1f);

        t22.transform.eulerAngles = new Vector3(0, 0, 0);
        t22.transform.position = new Vector3(-0.012556f, 5f, 1f);

        t23.transform.eulerAngles = new Vector3(0, 0, 0);
        t23.transform.position = new Vector3(2.7141f, 5f, 1f);

        t31.transform.eulerAngles = new Vector3(0, 0, 0);
        t31.transform.position = new Vector3(-2.7141f, 5f, -1.7141f);

        t32.transform.eulerAngles = new Vector3(0, 0, 0);
        t32.transform.position = new Vector3(-0.012556f, 5f, -1.7141f);

        t33.transform.eulerAngles = new Vector3(0, 0, 0);
        t33.transform.position = new Vector3(2.7141f, 5f, -1.7141f);

        GameObject prompt_text = GameObject.Find("Prompt T");

        prompt_text.transform.eulerAngles = new Vector3(0, 180, 0);
        prompt_text.transform.position = new Vector3(-0.05f, 3f, -2f);
    }

    public void on_right_click()
    {
        main.transform.position = new Vector3(9, 11, 0);
        main.transform.eulerAngles = new Vector3(-231, 90, 180);

        GameObject p1_t = GameObject.Find("Player 1");
        GameObject p2_t = GameObject.Find("Player 2");

        p1.transform.eulerAngles = new Vector3(0, 90, 0);
        p1.transform.position = new Vector3(-1f, 2f, -11f);

        p2.transform.eulerAngles = new Vector3(0, 90, 0);
        p2.transform.position = new Vector3(-1f, 2f, 11f);

        p1_t.transform.eulerAngles = new Vector3(90, 0, 90);
        p1_t.transform.position = new Vector3(-4.4f, 0f, -16.4f);

        p2_t.transform.eulerAngles = new Vector3(90, 0, 90);
        p2_t.transform.position = new Vector3(-4.4f, 0f, 11.6f);

        d_light.transform.eulerAngles = new Vector3(50, 140, 140);
        d_light.transform.position = new Vector3(-6, 13, 8);

        GameObject t11 = GameObject.Find("11T");
        GameObject t12 = GameObject.Find("12T");
        GameObject t13 = GameObject.Find("13T");
        GameObject t21 = GameObject.Find("21T");
        GameObject t22 = GameObject.Find("22T");
        GameObject t23 = GameObject.Find("23T");
        GameObject t31 = GameObject.Find("31T");
        GameObject t32 = GameObject.Find("32T");
        GameObject t33 = GameObject.Find("33T");

        t11.transform.eulerAngles = new Vector3(0, 90, 0);
        t11.transform.position = new Vector3(-1.7141f, 5f, 2.7141f);

        t12.transform.eulerAngles = new Vector3(0, 90, 0);
        t12.transform.position = new Vector3(0.987444f, 5f, 2.7141f);

        t13.transform.eulerAngles = new Vector3(0, 90, 0);
        t13.transform.position = new Vector3(3.7141f, 5f, 2.7141f);

        t21.transform.eulerAngles = new Vector3(0, 90, 0);
        t21.transform.position = new Vector3(-1.7141f, 5f, 0f);

        t22.transform.eulerAngles = new Vector3(0, 90, 0);
        t22.transform.position = new Vector3(0.987444f, 5f, 0f);

        t23.transform.eulerAngles = new Vector3(0, 90, 0);
        t23.transform.position = new Vector3(3.7141f, 5f, 0f);

        t31.transform.eulerAngles = new Vector3(0, 90, 0);
        t31.transform.position = new Vector3(-1.7141f, 5f, -2.7141f);

        t32.transform.eulerAngles = new Vector3(0, 90, 0);
        t32.transform.position = new Vector3(0.987444f, 5f, -2.7141f);

        t33.transform.eulerAngles = new Vector3(0, 90, 0);
        t33.transform.position = new Vector3(3.7141f, 5f, -2.7141f);

        GameObject prompt_text = GameObject.Find("Prompt T");

        prompt_text.transform.eulerAngles = new Vector3(0, 270, 0);
        prompt_text.transform.position = new Vector3(-2f, 3f, 0f);
    }

    public void on_left_click()
    {
        main.transform.position = new Vector3(-9, 11, 0);
        main.transform.eulerAngles = new Vector3(51, 90, 0);

        GameObject p1_t = GameObject.Find("Player 1");
        GameObject p2_t = GameObject.Find("Player 2");

        p1.transform.eulerAngles = new Vector3(0, 90, 0);
        p1.transform.position = new Vector3(0f, 2f, -11f);

        p2.transform.eulerAngles = new Vector3(0, 90, 0);
        p2.transform.position = new Vector3(0f, 2f, 11f);

        p1_t.transform.eulerAngles = new Vector3(90, 0, 270);
        p1_t.transform.position = new Vector3(3f, 0f, -11.6f);

        p2_t.transform.eulerAngles = new Vector3(90, 0, 270);
        p2_t.transform.position = new Vector3(3f, 0f, 16.4f);

        d_light.transform.eulerAngles = new Vector3(50, 140, 140);
        d_light.transform.position = new Vector3(-6, 13, 8);

        GameObject t11 = GameObject.Find("11T");
        GameObject t12 = GameObject.Find("12T");
        GameObject t13 = GameObject.Find("13T");
        GameObject t21 = GameObject.Find("21T");
        GameObject t22 = GameObject.Find("22T");
        GameObject t23 = GameObject.Find("23T");
        GameObject t31 = GameObject.Find("31T");
        GameObject t32 = GameObject.Find("32T");
        GameObject t33 = GameObject.Find("33T");

        t11.transform.eulerAngles = new Vector3(0, 90, 0);
        t11.transform.position = new Vector3(-3.7141f, 5f, 2.7141f);

        t12.transform.eulerAngles = new Vector3(0, 90, 0);
        t12.transform.position = new Vector3(-1.012556f, 5f, 2.7141f);

        t13.transform.eulerAngles = new Vector3(0, 90, 0);
        t13.transform.position = new Vector3(1.7141f, 5f, 2.7141f);

        t21.transform.eulerAngles = new Vector3(0, 90, 0);
        t21.transform.position = new Vector3(-3.7141f, 5f, 0f);

        t22.transform.eulerAngles = new Vector3(0, 90, 0);
        t22.transform.position = new Vector3(-1.012556f, 5f, 0f);

        t23.transform.eulerAngles = new Vector3(0, 90, 0);
        t23.transform.position = new Vector3(1.7141f, 5f, 0f);

        t31.transform.eulerAngles = new Vector3(0, 90, 0);
        t31.transform.position = new Vector3(-3.7141f, 5f, -2.7141f);

        t32.transform.eulerAngles = new Vector3(0, 90, 0);
        t32.transform.position = new Vector3(-1.012556f, 5f, -2.7141f);

        t33.transform.eulerAngles = new Vector3(0, 90, 0);
        t33.transform.position = new Vector3(1.7141f, 5f, -2.7141f);

        GameObject prompt_text = GameObject.Find("Prompt T");

        prompt_text.transform.eulerAngles = new Vector3(0, 90, 0);
        prompt_text.transform.position = new Vector3(2f, 3f, 0f);
    }
}
