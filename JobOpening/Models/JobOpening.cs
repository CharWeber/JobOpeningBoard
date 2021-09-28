using System.Collections.Generic;
using JobOpenings.Models;

namespace JobOpening.Models
{
  public class JobOpening
  {
    public string Title {get; set;}
    public string Description {get;set;}
    public Contact Contact {get; set;}
    private static List<JobOpening> _openings = new List <JobOpening> ();

    public JobOpening(string title, string description, string name, string email, string phoneNumber)
    {
      Title = title;
      Description = description;
      Contact = new Contact(name, email, phoneNumber);
      _openings.add(this);
    }
    public static List<JobOpening> GetAll()
    {
    return _openings;
    }

    public static void ClearAll()
    {
      _openings.Clear();
    }
  }
}