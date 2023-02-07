/*
 * @lc app=leetcode.cn id=1604 lang=csharp
 * @lcpr version=21504
 *
 * [1604] 警告一小时内使用相同员工卡大于等于三次的人
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Internal;
// @lc code=start
public class Solution {
    int ToMinute(string str) {
        var args = str.Split(':');
        return int.Parse(args[0]) * 60 +
            int.Parse(args[1]);
    }
    public IList<string> AlertNames(string[] keyName, string[] keyTime) {
        List<string> list = new List<string>();
        int length = keyName.Length;
        SortedDictionary<string, List<int>> DoorTime = new SortedDictionary<string, List<int>>();
        for (int i = 0; i < length; i++) {
            if (!DoorTime.ContainsKey(keyName[i])) {
                DoorTime[keyName[i]] = new List<int>();
            }
            DoorTime[keyName[i]].Add(ToMinute(keyTime[i]));
        }
        foreach (var item in DoorTime) {
            item.Value.Sort();
            for (int i = 2; i < item.Value.Count; i++) {
                if (item.Value[i] < item.Value[i - 1]) continue;
                if (item.Value[i - 1] < item.Value[i - 2]) continue;
                if (item.Value[i] - item.Value[i - 2] <= 60) {
                    list.Add(item.Key);
                    break;
                }
            }
        }
        return list;
    }
}
// @lc code=end

// @lcpr-div-debug-arg-start
// funName=
// paramTypes= []
// returnType=
// @lcpr-div-debug-arg-end


/*
// @lcpr case=start
// ["daniel","daniel","daniel","luis","luis","luis","luis"]\n["10:00","10:40","11:00","09:00","11:00","13:00","15:00"]\n
// @lcpr case=end

// @lcpr case=start
// ["alice","alice","alice","bob","bob","bob","bob"]\n["12:01","12:00","18:00","21:00","21:20","21:30","23:00"]\n
// @lcpr case=end

// @lcpr case=start
// ["john","john","john"]\n["23:58","23:59","00:01"]\n
// @lcpr case=end

// @lcpr case=start
// ["leslie","leslie","leslie","clare","clare","clare","clare"]\n["13:00","13:20","14:00","18:00","18:51","19:30","19:49"]\n
// @lcpr case=end

 */


