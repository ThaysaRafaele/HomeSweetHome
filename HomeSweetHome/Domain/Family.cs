namespace HomeSweetHome
{
    public class Family
    {
        public Family()
        {
            this.Name = "";
            this.Income = 0.0;
        }
        public Family(string name, double income)
        {
            this.Name = name;
            this.Income = income;
        }

        public string Name { get; set; }
        public double Income { get; set; }
    }
}
