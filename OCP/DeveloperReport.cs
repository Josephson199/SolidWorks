namespace OCP
{
    public class DeveloperReport
    {
        public DeveloperReport(string name, string level)
        {
            this.Name = name;
            this.Level = level;
        }

        public int Id { get; set; }
        public string Name { get; }
        public string Level { get; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
