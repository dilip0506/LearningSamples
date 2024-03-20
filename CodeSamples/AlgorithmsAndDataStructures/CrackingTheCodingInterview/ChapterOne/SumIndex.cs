namespace ChapterOne
{
    public class SumIndex
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        //Hashtable h = new Hashtable();//hashtable and delegate code
        //public int _Index(Hashtable ht, object y) {////hashtable and delegate code
        //    int len = ht.Count;
        //    for (int i = 0; i <= len-1; i++) {
        //        if(ht[i].Equals(y)){
        //            return i;
        //        }
        //        Console.WriteLine("type:{0}, value:{1} y:{2}", ht[i].GetType(), ht[i], y);
        //    }
        //    return 0;
        //}
        //delegate int Index(Hashtable num, object y);//hashtable and delegate code
        public int[] TwoSum(int[] nums, int target)
        {
            //SumIndex si = new SumIndex();
            // Index ind = new Index(si._Index);
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                d.Add(i, nums[i]);
                //    h.Add(i, nums[i]);//hashtable and delegate code
            }
            for (int j = 0; j < len; j++)
            {
                int res = target - nums[j];
                int g = d.FirstOrDefault(x => x.Value == res).Key;
                if (d.ContainsValue(res) && (g != j))
                {
                    return new int[] { j, g };
                }
                // h.Add(j, nums[j]);//one way
            }
            return new int[] {0};
        }
        // Brute force
        //public int[] TwoSum(int[] nums, int target)
        //{
        //    int len = nums.Length;
        //    for (int j = 0; j < len; j++)
        //    {
        //        for (int i = j + 1; i < len; i++)
        //        {
        //            if (nums[j] == target - nums[i])
        //            {
        //                return new int[] { j, i };
        //            }
        //        }
        //    }
        //    return null;
        //}
        static void Run()
        {
            SumIndex s = new SumIndex();
            int[] l = { 2, 5, 5, 11 };
            int[] j = s.TwoSum(l, 10);
            if (j != null)
            {
                foreach (int h in j)
                {
                    Console.WriteLine(h);
                }
            }

            Console.Read();
        }
    }
}