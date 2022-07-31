using System.Numerics;

public class MultiplyString
{
    public string Multiply(string num1, string num2) {
       BigInteger n1= BigInteger.Parse(num1);
       BigInteger n2= BigInteger.Parse(num2);
        return (n1*n2).ToString() ;
    }
}
