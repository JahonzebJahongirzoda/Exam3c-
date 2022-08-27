namespace Infrastructure.Services;
  
public class DepartmentService
{ 
    List<Department> departmentt = new List<Department>();
       public List<Department> GetDepartments(){
         return departmentt;
     }
public void Add(Department department)
     {
        departmentt.Add(department);
     }

  
    public void Update(Department department, int id)
    {
        var item = departmentt.Find(x=>x.Id == id);
        item.Name = departmentt.Name;
        item.Description = departmentt.Description;
    } 
    
     public Department GetDepartmentById(int id)
    {
       var department =  departmentt.Find(item=> item.Id == id);
       return department;

       
    }
    public void Delete(int id)
    {
        var item = departmentt.Find(x=>x.Id == id);
        departmentt.Remove(item);
    }
    
    public int Count()
    {
        int count=departmentt.Count();
        return count;
    }
   
}