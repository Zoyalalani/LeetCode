using System;
using System.Collections.Generic;

public class FindDuplicates
{
    public IList<int> FindDups(int[] nums)
    {
        var dups = nums.GroupBy(x=>x).Where(group=>group.Count() > 1).SelectMany(y=> y).Distinct().ToList();
        return dups;
    }
}