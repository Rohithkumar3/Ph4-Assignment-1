namespace Assignment_1
{
    public class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Sub()
        {
            int res;
            res = num1 - num2;
            return res;
        }
        public int Mul()
        {
            int res;
            res = num1 * num2;
            return res;
        }
        public int Div()
        {
            int res;
            res = num1 / num2;
            return res;
        }
    }
}