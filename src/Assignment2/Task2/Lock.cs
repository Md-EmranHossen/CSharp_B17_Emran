using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2 {
  public class Lock 
  {
    private string lockStatus; // Correct lock status are: Open & Close

    
    public string LockStatus 
    {
      get 
      {
        if (lockStatus == "Open" || lockStatus == "Close") 
        {
          return lockStatus;
        } 
        else 
        {
          lockStatus = "Incorrect Status";
          return lockStatus;
        }
      }
      set 
      {
        lockStatus = value;
      }
    }
  }
}