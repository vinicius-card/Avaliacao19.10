using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Avaliação19._10.Data;

namespace Avaliação19._10.Pages.Alunos
{
    public class DeleteModel : PageModel
    {
        private readonly Avaliação19._10.Data.Avaliação19_10Context _context;

        public DeleteModel(Avaliação19._10.Data.Avaliação19_10Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Aluno Aluno { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aluno = await _context.Aluno.FirstOrDefaultAsync(m => m.ID == id);

            if (Aluno == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aluno = await _context.Aluno.FindAsync(id);

            if (Aluno != null)
            {
                _context.Aluno.Remove(Aluno);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
