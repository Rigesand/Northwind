namespace Northwind.DAL.Entities
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Title { get; set; }
        public string Title_of_Courtesy { get; set; }
        public DateTimeOffset Birth_Date { get; set; }
        public DateTimeOffset Hire_Date { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postal_Code { get; set; }
        public string Country { get; set; }
        public string Home_Phone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public int Reports_To { get; set; }
        public string Photo_Path { get; set; }
    }
}
