#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TINTUC.Models;

namespace TINTUC.Pages_Comment
{
    public class IndexModel : PageModel
    {
        private readonly DataComment _context;

        public IndexModel(DataComment context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get;set; }

        public async Task OnGetAsync()
        {
            Comment = await _context.comment.ToListAsync();
        }
    }
}
