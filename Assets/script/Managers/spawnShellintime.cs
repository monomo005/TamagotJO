using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnShellintime : MonoBehaviour
{
#region Time Variable
    public TimeManager2 time;

    public int hours; //เซ็ทชั่วโมง
    public int minutes; //เซ็ทนาที
    public int seconds; //เซ็ทวินาที

    private bool _timerComplete = false;
    private bool _timerIsReady;
    private TimeSpan _startTime;
    private TimeSpan _endTime;
    private TimeSpan _remainingTime;

    #endregion
    private float _value = 1f;

    public int RewardToEarn;

    public List<GameObject> prefabsToSpawn;
    public string spawnPointTag = "sometag";
    public bool alwaysSpawn = true;

    public bool checkShell = false;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("_timer") == "")
        {
            Debug.Log("Enable Button");
            SpawnShell();
        }

        else
        {
            StartCoroutine("CheckTime");
            DisableShell();
        }
    }

    void updateTime()
    {
        if (PlayerPrefs.GetString("_timer") == "Standby")
        {
            PlayerPrefs.SetString("_timer", TimeManager.sharedInstance.getCurrentTimeNow());
            PlayerPrefs.SetInt("_date", TimeManager.sharedInstance.getCurrentDateNow());
        }

        else if (PlayerPrefs.GetString("_timer") != "" && PlayerPrefs.GetString("_timer") != "Standby")
        {
            int _old = PlayerPrefs.GetInt("_date");
            int _now = TimeManager.sharedInstance.getCurrentDateNow();

            //ตรวจว่าผ่านวันนี้ไปรึยัง
            if (_now > _old)
            {
                //วันนี้ได้ผ่านไปแล้ว
                Debug.Log("วันนี้ผ่านไปแล้ว");
                SpawnShell();
                return;
            }
            else if (_now == _old)
            {
                //วันเดิม
                Debug.Log("วันเดิม");
                ConfigTimerSettings();
                return;
            }
            else
            {
                Debug.Log("หาวันไม่ได้");
                return;
            }
        }

        Debug.Log("วันได้ผ่านไปแล้ว");
        ConfigTimerSettings();
    }

    void ConfigTimerSettings()
    {
        _startTime = TimeSpan.Parse(PlayerPrefs.GetString("_timer"));
        _endTime = TimeSpan.Parse(hours + ":" + minutes + ":" + seconds);
        TimeSpan temp = TimeSpan.Parse(TimeManager.sharedInstance.getCurrentTimeNow());
        TimeSpan diff = temp.Subtract(_startTime);
        _remainingTime = _endTime.Subtract(diff);

        //เก็บเวลาเมื่อออก
        SetProgressWhereWeLeft();

        if (diff >= _endTime)
        {
            _timerComplete = true;
            SpawnShell();
        }
        else 
        {
            _timerComplete = false;
            DisableShell();
            _timerIsReady = true;
        }
    }

    void SetProgressWhereWeLeft()
    {
        float ah = 1f / (float)_endTime.TotalSeconds;
        float bh = 1f / (float)_remainingTime.TotalSeconds;
        _value = ah / bh;
    }


    IEnumerator CheckTime()
    {
        DisableShell();
        
        yield return StartCoroutine(TimeManager.sharedInstance.GetServerTime());
        updateTime();
        Debug.Log("Time check complete!");
    }

    public void ShellClick()
    {
        claimReward(RewardToEarn);
        PlayerPrefs.SetString("_timer", "Standby");
        StartCoroutine("CheckTime");
    }
    //enable Coconut
    void SpawnShell()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
        foreach (GameObject spawnPoint in spawnPoints)
        {
            int randomPrefab = UnityEngine.Random.Range(0, prefabsToSpawn.Count);
            if (alwaysSpawn)
            {
                GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
                pts.transform.position = spawnPoint.transform.position;
                alwaysSpawn = false;
            }
            else
            {
                int spawnOrNot = UnityEngine.Random.Range(0, 2);
                if (spawnOrNot == 0)
                {
                    GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
                    pts.transform.position = spawnPoint.transform.position;
                    alwaysSpawn = false;
                }
            }
        }
    }

    void DisableShell()
    {
        foreach (var prefab in prefabsToSpawn)
        {
            //prefab.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (_timerIsReady)
        {
            if (!_timerComplete && PlayerPrefs.GetString("_timer") != "")
            {
                _value -= Time.deltaTime * 1f / (float)_endTime.TotalSeconds;

                //this is called once only
                if (_value <= 0 && !_timerComplete)
                {
                    //when the timer hits 0, let do a quick validation to make sure no speed hacks.
                    validateTime();
                    _timerComplete = true;
                }
            }
        }
    }

    private void validateTime()
    {
        Debug.Log("==> Validating time to make sure no speed hack!");
        StartCoroutine("CheckTime");
    }

    private void claimReward(int x)
    {
        Debug.Log("YOU EARN " + x + " REWARDS");
    }

    public void rewardClicked()
    {
        Debug.Log("==> Claim Button Clicked");
        claimReward(RewardToEarn);
        PlayerPrefs.SetString("_timer", "Standby");
        StartCoroutine("CheckTime");
    }
}
