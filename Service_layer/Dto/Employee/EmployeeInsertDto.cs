namespace project_cls.Service_layer.Dto.Employee
{
    public class EmployeeInsertDto
    {
       
        public string EmpName { get; set; }
      
        public string postion { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salary { get; set; }

        public int DeptId { get; set; } 

    }
}
