using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClubFlow.Models;
using System.Threading.Tasks;
using ClubFlow.Interfaces;

namespace ClubFlow.ViewModels
{
    public class LoginRegisterViewModel 
    {

        
        public RegisterLoginModel registerLoginModel { get; set; } = new();
       
        public User user { get; set; } = new();

    }

  

    
}
