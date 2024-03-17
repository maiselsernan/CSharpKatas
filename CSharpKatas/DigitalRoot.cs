namespace CSharpKatas
{
    public class DigitalRoot
    {
        public  int CalculateDigitalRoot(long n)
        {
            long sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            if (sum >9)
            {
                return CalculateDigitalRoot(sum);
            }
            return (int) sum;
                       
        }
    }
}
