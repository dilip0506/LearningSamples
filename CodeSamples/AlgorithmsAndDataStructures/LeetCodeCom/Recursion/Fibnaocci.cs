
namespace Recursion
{
    public class Fibnocci
    {
        public int F(int n){
            if(n <= 1){
                return 1;
            }else{
                return F(n - 1) + F(n-2);
            }
        }
    }
}