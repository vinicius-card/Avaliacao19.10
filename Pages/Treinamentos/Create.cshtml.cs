using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Avaliação19._10.Data;

namespace Avaliação19._10.Pages.Treinamentos
{
    public class CreateModel : PageModel
    {
        private readonly Avaliação19._10.Data.Avaliação19_10Context _context;

        public CreateModel(Avaliação19._10.Data.Avaliação19_10Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Treinamento Treinamento { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Treinamento.Add(Treinamento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
