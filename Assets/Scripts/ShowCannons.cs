using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCannons : MonoBehaviour
{
    private int level = 0;
    public Image UpgradeImage;
    public GameObject cannon_1;
    public GameObject cannon_2;
    public GameObject cannon_3;
    public void CannonEnabled()
    {
        if (level == 0)
        {
            cannon_1.SetActive(true);
            level++;
            UpgradeImage.fillAmount = 0f;
        }
        else if (level == 1)
        {
            cannon_1.SetActive(true);
            cannon_2.SetActive(true);
            level++;
            UpgradeImage.fillAmount = 0f;
        }
        else if (level == 2)
        {
            cannon_1.SetActive(true);
            cannon_2.SetActive(true);
            cannon_3.SetActive(true);
            level++;
            UpgradeImage.fillAmount = 0f;
        }

    }
}