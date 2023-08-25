namespace Solutions._0649Dota2Senate;

public class Solution
{
    public string PredictPartyVictory(string senate)
    {
        Queue<int> queueR = new();
        Queue<int> queueD = new();
        for (int i = 0; i < senate.Length; i++)
        {
            if (senate[i] == 'R') queueR.Enqueue(i);
            else queueD.Enqueue(i);
        }

        int newIndex = senate.Length;
        while (queueD.Count > 0 && queueR.Count > 0)
        {
            var dVal = queueD.Dequeue();
            var rVal = queueR.Dequeue();
            if(dVal<rVal) queueD.Enqueue(newIndex); // there won't be equal situation
            else queueR.Enqueue(newIndex);
            newIndex++;
        }

        if (queueD.Count > queueR.Count) return "Dire";
        else return "Radiant";
    }
}