﻿using ChatApplication.Core.Abstract;
using ChatApplication.Entities.Domain;
using ChatApplication.Sahred.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Core.Concrete.EntityFramework.Repositories
{
    public class EfChatRepository : Repository<Chat>, IChatRepository
    {
        public EfChatRepository(DbContext context) : base(context)
        {
        }
    }
}
