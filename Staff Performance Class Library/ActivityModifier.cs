namespace Staff_Performance_Class_Library
{
    public class ActivityModifier
    {
        public ActivityModifier() { }
        public int ID { get; set; }
        public int ActivityID { get; set; }
        public string Name { get; set; }
        public int RatingAdjustment { get; set; }
        public bool IsActive { get; set; }
    }
}