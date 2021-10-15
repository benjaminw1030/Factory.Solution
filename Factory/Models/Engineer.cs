using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    [Display(Name = "Job Title")]
    public string JobTitle { get; set; }
    [Display(Name = "Hire Date")]
    public DateTime HireDate { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}