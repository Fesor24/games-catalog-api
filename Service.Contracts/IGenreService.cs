﻿using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDto>> GetAllGenres(bool trackChanges);
    }
}
