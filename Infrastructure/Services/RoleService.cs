namespace Infrastructure.Services;
  
public class RoleService
{ 
    List<Role> roleee = new List<Role>();
       public List<Role> GetRoles(){
         return roleee;
     }
public void Add(Role role)
     {
        roleee.Add(role);
     }

  
    public void Update(Role role, int id)
    {
        var item = roleee.Find(x=>x.Id == id);
        item.Name = roleee.Name;
        item.EmployeeId = roleee.EmployeeId;
        item.Description = roleee.Description;
    } 
    
     public Role GetRoleById(int id)
    {
       var role =  roleee.Find(item=> item.Id == id);
       return role;

       
    }
    public void Delete(int id)
    {
        var item = roleee.Find(x=>x.Id == id);
        roleee.Remove(item);
    }
    
    public int Count()
    {
        int count=roleee.Count();
        return count;
    }
   
}