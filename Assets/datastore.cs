using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class datastore : MonoBehaviour
{
    const string KEY = "data";
    [SerializeField]
    List<ScriptableQuest> quests = new List<ScriptableQuest>();
    [SerializeField]
    AnswerData answerData;
    [SerializeField]
    UnityEngine.Events.UnityEvent onWin;
    [SerializeField]
    bool clear = false;
    private void Awake()
    {
        Refresh();
        checkWin();
    }
    public void setCorrect(ScriptableQuest q)
    {
        answerData.PassedQuests.Add(q.name);
        answerData.PassedQuests = answerData.PassedQuests.Distinct().ToList();
        PlayerPrefs.SetString(KEY, JsonUtility.ToJson(answerData));
    }

    internal bool has(ScriptableQuest quest)
    {
        Refresh();
        return answerData.PassedQuests.Contains(quest.name);
    }
    private void OnValidate()
    {
        if (clear)
        {

            answerData.PassedQuests = new List<string>();
            PlayerPrefs.SetString(KEY, JsonUtility.ToJson(answerData));
            Refresh();
            clear = false;
        }
    }
    private void Refresh()
    {
        string data = PlayerPrefs.GetString(KEY);
        try
        {
            if (data != default)
                answerData = JsonUtility.FromJson<AnswerData>(data);
        }
        finally
        {
            if (answerData == null)
                answerData = new AnswerData();
        }
    }
    private bool x(ScriptableQuest q)
    {
        if (answerData != null && answerData.PassedQuests != null)
            return !answerData.PassedQuests.Contains(q.name);
        return false;
    }
    public void checkWin()
    {
        Refresh();
        var todo = quests.Where(x).Count();
        if (todo <= 0)
            onWin.Invoke();

    }
}

[System.Serializable]
public class AnswerData
{
    public List<string> PassedQuests = new List<string>();
}