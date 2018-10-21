using Domain.Models;
using System.ComponentModel.DataAnnotations;
using WebApplication.Models;

namespace WebApplication.Models
{
    public class BlogModel
    {
        public long Id;

        [Required]
        public string Title;

        [Required]
        public string Text;
    }
}