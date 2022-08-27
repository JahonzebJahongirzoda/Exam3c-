namespace Infrastructure.Services;
  
public class ExperienceService
{ 
    List<Experience> experiencee = new List<Experience>();
       public List<Experience> GetExperiences(){
         return experiencee;
     }
public void Add(Experience experience)
     {
        experiencee.Add(experience);
     }

  
    public void Update(Experience experience, int id)
    {
        var item = experiencee.Find(x=>x.Id == id);
        item.Name = experiencee.Name;
        item.Company = experiencee.Company;
         item.EmployeeId = experiencee.EmployeeId;
        item.Description = experiencee.Description;
    } 
    
     public Experience GetExperienceById(int id)
    {
       var experience =  experiencee.Find(item=> item.Id == id);
       return experience;

       
    }
    public void Delete(int id)
    {
        var item = experiencee.Find(x=>x.Id == id);
        experiencee.Remove(item);
    }
    
    public int Count()
    {
        int count=experiencee.Count();
        return count;
    }
   
}