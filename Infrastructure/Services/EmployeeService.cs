namespace Infrastructure.Services;
  
public class EmployeeService
{ 
    List<Employee> employeee = new List<Employee>();
       public List<Employee> GetEmployees(){
         return employeee;
     }
public void Add(Employee employee)
     {
        employeee.Add(employee);
     }

  
    public void Update(Employee employee, int id)
    {
        var item = employeee.Find(x=>x.Id == id);
        item.FirstName = employeee.FirstName;
        item.BirthDate = employeee.BirthDate;
        item.Address = employeee.Address;
        item.Phone = employeee.Phone;
        item.Department = employeee.Department;
        item.Experiences = employeee.Experiences;
        item.Roles = employeee.Roles; 
        item.Description = employeee.Description;
    } 
    
     public Employee GetEmployeeById(int id)
    {
       var employee =  employeee.Find(item=> item.Id == id);
       return employee;

       
    }
    public void Delete(int id)
    {
        var item = employeee.Find(x=>x.Id == id);
        employeee.Remove(item);
    }
    
    public int Count()
    {
        int count=employeee.Count();
        return count;
    }
   
}