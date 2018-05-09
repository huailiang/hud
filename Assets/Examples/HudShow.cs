using UnityEngine;

public class HudShow : MonoBehaviour
{
    Hud hud;

    Rect rect = new Rect(10, 10, 100, 30);
    float val = 0.2f;

    void Start()
    {
        hud = new Hud("赵子龙", 0.3f);
    }


    private void OnGUI()
    {
        val = GUI.HorizontalSlider(rect, val, 0f, 1f);
        hud.UpdateHud(val);
    }
}
