using System;

namespace EntityLibrary
{
	public class Orders
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionOfProblem { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Deadline { get; set; }
        public int StatusId { get; set; }
        public int AccountId { get; set; }
        public int EmployeeId { get; set; }
        public decimal Pirce { get; set; }
        public string Feedback { get; set; }
    }
}
