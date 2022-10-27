using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Billboard : MonoBehaviour
{
    public Transform cam;
    public string planet;
    public Body body;
    public GameObject canvas;

    private TextMeshProUGUI planetText;
    private TextMeshProUGUI massText;
    private Slider massSlider;
    private TextMeshProUGUI velocityText;
    private Slider velocitySlider;

    void Start()
    {
        cam = Camera.main.transform;
        planetText = canvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        planetText.text = planet;

        massText = canvas.transform.GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>();
        massSlider = canvas.transform.GetChild(2).GetChild(1).GetComponent<Slider>();
        velocityText = canvas.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>();
        velocitySlider = canvas.transform.GetChild(3).GetChild(1).GetComponent<Slider>();
        canvas.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        massText.text = "Mass: " + massSlider.value;
        velocityText.text = "Velocity: " + velocitySlider.value;

    }

    void LateUpdate()
    {
        canvas.transform.LookAt(canvas.transform.position + cam.forward);
    }

    public void changeVisibility(bool b)
    {
        canvas.GetComponent<Canvas>().enabled = b;
    }
}