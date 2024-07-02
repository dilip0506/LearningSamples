using System.Xml.XPath;

namespace LeetCodeCom
{
    public class Fibnocci{

        public static int F(int n){
            int a = 0, b = 1, c = 0;

            if(n == 0 ) return 0;

            for(int i = 2; i <= n; i++){
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}