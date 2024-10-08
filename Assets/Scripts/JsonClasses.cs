using System;
using UnityEngine;

public class RequestResponse
{
    public string command = "reset";

    public string to_json()
    {
        return JsonUtility.ToJson(this);
    }
}

[Serializable]
public class ResetResponse : RequestResponse
{
    public float[] observation;
    public int setting_up_duration = 0;
    public string command = "reset";
    public bool pause = false;
}


[Serializable]
public class StepResponse : RequestResponse
{
    public float[] observation;
    public bool done;
    public int fps;
    public float duration_pause;
    public float distance_from_goal;
    public int human_action;
    public int agent_action;
    public string command = "step";
}

[Serializable]
public class StepRequest : RequestResponse
{
    public int action_agent = 0;
    public int second_agent_action = 0;
    public int action_duration = 0;
    public bool timed_out = false;
    public string mode = "init";
    public string command = "step";
}

[Serializable]
public class TrainingRequest : RequestResponse
{
    public int cycle = 0;
    public int total_cycles = 0;
    public string command = "training";
}

[Serializable]
public class CommandRequest : RequestResponse
{
    public string command;
    public StepRequest step_request = null;
    public TrainingRequest training_request = null;
}

[Serializable]
public class GameConfig : RequestResponse
{
    public bool discrete_input = false;
    public int max_duration = 40;
    public bool human_assist = false;
    public bool human_only = false;
    public float action_duration = 0.2f;
    public float human_speed = 0.2f;
    public float agent_speed = 0.2f;
    public float discrete_angle_change = 10;
    public int start_up_screen_display_duration = 2;
    public int popup_window_time = 3;
}   

[Serializable]
public class EnvVariables : RequestResponse
{
    public string host;
}