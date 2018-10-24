using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{

    public GameObject achievementPrefab;

    public Sprite[] sprites;

	void Start ()
    {
        CreateAchievement("General", "Test Title", "This is the description of the achievement", 10, 0);
	}

	void Update ()
    {
		
	}

    public void CreateAchievement(string category, string title, string desc, int point, int spriteIndex)
    {
        GameObject achievement = Instantiate(achievementPrefab);

        SetAchievementInfo(category, title, desc, point, spriteIndex, achievement);
    }

    public void SetAchievementInfo(string category, string title, string desc, int point, int spriteIndex, GameObject achievement)
    {
        achievement.transform.SetParent(GameObject.Find(category).transform);
        achievement.transform.localScale = new Vector3(1, 1, 1);
        achievement.transform.GetChild(0).GetComponent<Text>().text = title;
        achievement.transform.GetChild(1).GetComponent<Text>().text = desc;
        achievement.transform.GetChild(2).GetComponent<Text>().text = point.ToString();
        achievement.transform.GetChild(3).GetComponent<Image>().sprite = sprites[spriteIndex];
    }
}
