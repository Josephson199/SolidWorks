namespace OCP
{
    public class DeveloperReport
    {
        public DeveloperReport(string name)
        {
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; }
        public Level Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }

    public enum Level
    {
        Junior,
        Senior
    }
}
