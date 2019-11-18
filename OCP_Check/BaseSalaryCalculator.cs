namespace OCP_Check
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; }

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();
    }
}
