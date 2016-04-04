using UnityEngine;
using System.Collections;

[AddComponentMenu("Suppressors/TimeOfDay")]
public class TimeOfDaySupressor : Suppressor
{
    [Range(0, 23)]
    public int startHour;

    [Range(0, 59)]
    public int startMinutes;

    [Range(0, 23)]
    public int endHour;

    [Range(0, 59)]
    public int endMinutes;

    private bool isSuppressing;

    public void OnEnable()
    {
        isSuppressing = false;
    }
    public override void Update()
    {
        if (isAfterStart() && isBeforeEnd())
        {
            if (!isSuppressing)
            {
                isSuppressing = true;
                suppress(true);
            }
        }
        else
        {
            if (isSuppressing)
            {
                isSuppressing = false;
                suppress(false);
            }
        }
        base.Update();
    }

    public bool isAfterStart()
    {
        System.DateTime date = System.DateTime.Now;

        if (date.Hour == startHour)
        {
            //We are on the hour, check if minutes are past
            return date.Minute >= startMinutes;
        }
        else
        {
            return date.Hour > startHour;
        }
    }

    public bool isBeforeEnd()
    {
        System.DateTime date = System.DateTime.Now;

        if (date.Hour == endHour)
        {
            //We are on the hour, check if minutes are past
            return date.Minute < endMinutes;
        }
        else
        {
            return date.Hour < endHour;
        }
    }
}
