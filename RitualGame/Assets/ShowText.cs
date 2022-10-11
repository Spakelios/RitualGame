using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowText : MonoBehaviour
{
    public TextMeshProUGUI Text;

    void Update()
    {
        Text.text = "Boss Score " + InfoStorage.BossPoint;
    }
}
