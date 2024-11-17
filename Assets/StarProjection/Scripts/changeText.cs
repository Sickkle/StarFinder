using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeText : MonoBehaviour
{
    public TMP_Text Text;
    public GetStarInfo starInfo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text = GetComponent<TextMeshProUGUI>();
        Text.text = starInfo.starName;
    }
}
