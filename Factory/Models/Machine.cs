using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string Name { get; set; }
    public string Function { get; set; }
    [Display(Name = "Calibration Date")]
    public DateTime CalibrationDate { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}