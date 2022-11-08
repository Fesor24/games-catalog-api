﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IGamesRepository
    {
        IEnumerable<Game> GetAllGames(bool trackChanges);
        Game GetGameById(int id, bool trackChanges);

        void CreateGame(Game game);

        void DeleteGame(Game game);

       
    }
}
