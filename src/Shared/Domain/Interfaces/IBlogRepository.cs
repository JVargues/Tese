using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAll();

        Blog GetById(long id);

        void Save(Blog blog);

        void Update(Blog blog);

        void Delete(Blog blog);
    }
}
