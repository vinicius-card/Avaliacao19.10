using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Avaliação19._10.Data;

namespace Avaliação19._10.Pages.Funcionarios
{
    public class IndexModel : PageModel
    {
        private readonly Avaliação19._10.Data.Avaliação19_10Context _context;

        public IndexModel(Avaliação19._10.Data.Avaliação19_10Context context)
        {
            _context = context;
        }

        public IList<Funcionario> Funcionario { get;set; }

        public async Task OnGetAsync()
        {
            Funcionario = await _context.Funcionario.ToListAsync();
        }
    }
}
