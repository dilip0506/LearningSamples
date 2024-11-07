
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

        public static void Run(){
            var F = new Fibnocci().F(100);
            Console.Write(F);
        }
    }
}