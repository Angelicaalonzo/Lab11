﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab11.Models;


namespace Lab11.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProfessorDbContext _context;
        public List<Professor> Professors{ get; set;}
        public IndexModel(ProfessorDbContext context)
            {
                _context = context;
            }

        public void OnGet()
        {
        Professors = _context.Professor.ToList(); 
        }
    }
}
