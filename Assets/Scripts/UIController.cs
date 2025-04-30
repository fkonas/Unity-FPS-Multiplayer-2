using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    private void Awake()
    {
        instance = this;
    }

    public TMP_Text overheatedMessage;
    public Slider weaponTempSlider;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
