﻿using Quizzed.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzed.Contracts
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAllAnswers(bool trackChanges);
    }
}
