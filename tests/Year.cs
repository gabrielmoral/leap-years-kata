namespace tests
{
    internal class Year
    {
        private readonly int _year;

        public Year(int year)
        {
            _year = year;
        }

        public bool IsLeap()
        {
            return IsDivisibleBy(400) || IsDivisibleBy(4) && !IsDivisibleBy(100);
        }
        
        private bool IsDivisibleBy(int n)
        {
            return _year % n == 0;
        }
    }
}