using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

	public class Accounts
	{
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }

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

    public class ReadynessStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order_SolvedProblemType
	{
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int SolvedProblemTypeId { get; set; }
    }

	public class SolvedProblemType
	{
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
