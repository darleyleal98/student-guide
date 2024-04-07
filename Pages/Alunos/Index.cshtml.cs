using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentGuide.Data;
using StudentGuide.Models;

namespace StudentGuide.Pages_Alunos
{
    public class IndexModel : PageModel
    {
        private readonly StudentGuide.Data.ApplicationDbContext _context;

        public IndexModel(StudentGuide.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Aluno = await _context.Aluno.ToListAsync();
        }
    }
}
