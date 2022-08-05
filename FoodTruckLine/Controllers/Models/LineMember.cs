namespace FoodTruckLine.Controllers.Models
{
    public class LineMemberDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReservedTime { get; set; }
        public string ReservedDate { get; set; }

        public LineMemberDto()
        {
        }

        public LineMemberDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public LineMemberDto(int id, string name, string reservedTime, string reservedDate)
        {
            Id = id;
            Name = name;
            ReservedTime = reservedTime;
            ReservedDate = reservedDate;
        }
    }
}
