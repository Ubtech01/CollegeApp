namespace CollegeApp.Models
{
    public static class CollegeRepository
    {
        public static List<Student> students { get; set; } = new List<Student>()
      {
          new Student()
          {
              Id = 1,
              Name = "Ubong",
              Email = "ubong@gmail.com",
              Address = "No 10 Ewet",
          },
          new Student()
          {
              Id = 2,
              Name = "Ken",
              Email = "ken@gmail.com",
              Address = "N0 12 Oron",
          }
      };
    }
}
