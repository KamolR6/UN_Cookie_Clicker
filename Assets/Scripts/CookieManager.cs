using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class NewMonoBehaviourScript : MonoBehaviour
{
    public int cookies = 0;
    public int price = 10;
    public int bonus = 0;
    private float timer = 0f;
    public TMP_Text ClickCount;
    public Button Cookie;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f) {
            cookies += bonus;
            timer -= 1f;
            UpdText();
        }
    }

    public void CookieClicked() {
        cookies++;
        UpdText();
    }

    public void UpgClicked() {
        if (cookies >= price) {
            cookies -= price;
            price *= 2;
            bonus++;
            UpdText();
        }
    }

    public void UpdText() {
        ClickCount.text = "Ciastka: " + cookies;
    }

}
