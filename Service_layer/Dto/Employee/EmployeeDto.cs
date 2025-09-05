using project_cls.DAL.DataAccess.Models;

namespace project_cls.Service_layer.Dto.Employee
{

  public class EmployeeDto
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string Position { get; set; }
    public string username { get; set; }
     public string password { get; set; }
     public string salary { get; set; }
        public string DeptName { get; set; }

}
}