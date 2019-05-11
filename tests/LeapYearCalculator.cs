namespace tests
{
    public static class LeapYearCalculator
    {
        public static bool IsLeap(int year)
        {
            var currentYear = new Year(year);
            return currentYear.IsLeap();
        }
    }
}