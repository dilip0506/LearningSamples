#include <vector>
class solution
{
public:
    int climbStairs(int n)
    {
        if (n < 0)
        {
            return 0;
        }
        if (n < 1)
        {
            return 1;
        }
        return climbStairs(n - 2) + climbStairs(n - 1);
    }

public:
    int climbStairs(int n)
    {
        if (n <= 2)
            return n;

        vector<int> dp(n + 1, 0);
        dp[1] = 1;
        dp[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }
};
